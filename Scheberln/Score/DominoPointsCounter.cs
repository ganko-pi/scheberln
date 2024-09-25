using System;
using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.Score;

/// <summary>
/// Implementation of <see cref="IPointsCounter"/> representing a counter of points for a deal with <see cref="Objective"/> <see cref="Objective.Domino"/>.
/// </summary>
public class DominoPointsCounter : IPointsCounter
{

    /// <inheritdoc/>
    public Objective Objective { get; } = Objective.Domino;

    /// <inheritdoc/>
    public int PointsPerTrick { get; } = 0;

    /// <summary>
    /// The points rewarded to an <see cref="IPlayer"/> for a certain rank at the end of a deal.
    /// </summary>
    public List<int> PointsPerRank { get; } = new List<int>()
    {
        20,
        8,
        4,
    };

    /// <inheritdoc/>
    /// <exception cref="ArgumentException">
    /// Exception if passed objective in <paramref name="gameState"/> does not match <see cref="Objective"/>.
    /// </exception>
    public Dictionary<IPlayer, int> CountPointsAfterDeal(GameState gameState)
    {
        Objective? currentObjective = gameState.CurrentObjective;
        if (currentObjective != Objective)
        {
            throw new ArgumentException($"The objective \"{currentObjective}\" passed to {nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.CurrentObjective)} does not match the objective \"{Objective}\" of class {nameof(DominoPointsCounter)}.");
        }

        List<IPlayer> players = gameState.Players;
        if (players.Count < PointsPerRank.Count)
        {
            throw new ArgumentException($"There are only {players.Count} players passed to {nameof(DominoPointsCounter)}.{nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.Players)} but at least {PointsPerRank.Count} players are needed.");
        }

        List<Card?> allPlayedCardsInDeal = gameState.AllPlayedCardsInDeal;

        IPlayer? dealer = gameState.Dealer;
        if (dealer == null)
        {
            throw new ArgumentException($"Dealer in {nameof(DominoPointsCounter)}.{nameof(CountPointsAfterDeal)} is null.");
        }

        List<Card> playedCards = allPlayedCardsInDeal
            .Where(card => card != null)
            .Distinct()
            .Cast<Card>()
            .ToList();
        if (playedCards.Count != gameState.Deck.Cards.Count)
        {
            throw new ArgumentException($"The \"{allPlayedCardsInDeal.GetType()}\" passed to {nameof(DominoPointsCounter)}.{nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.AllPlayedCardsInDeal)} does not contain all cards from \"{nameof(Deck)}\".");
        }

        Dictionary<IPlayer, List<Card?>> playedCardsPerPlayer = players.ToDictionary(player => player, player => new List<Card?>());

        IPlayer? firstPlayer = null;
        IPlayer currentPlayer = GameHelpers.Instance.GetNextPlayer(players, dealer);
        foreach (Card? card in allPlayedCardsInDeal)
        {
            if (firstPlayer == null && card == null)
            {
                currentPlayer = GameHelpers.Instance.GetNextPlayer(players, currentPlayer);
                continue;
            }

            firstPlayer ??= currentPlayer;

            playedCardsPerPlayer[currentPlayer].Add(card);
            currentPlayer = GameHelpers.Instance.GetNextPlayer(players, currentPlayer);
        }

        int numberOfCardsPerPlayer = playedCardsPerPlayer.First().Value.Where(card => card != null).Count();
        if (playedCardsPerPlayer.Any(playedCardsOfAPlayer => playedCardsOfAPlayer.Value.Where(card => card != null).Count() != numberOfCardsPerPlayer))
        {
            throw new ArgumentException($"The \"{allPlayedCardsInDeal.GetType()}\" passed to {nameof(DominoPointsCounter)}.{nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.AllPlayedCardsInDeal)} did not evenly distribute the cards to all players.");
        }

        Dictionary<IPlayer, int> playsUntilAllCardsPlayed = players.ToDictionary(player => player, player => 0);
        foreach ((IPlayer player, List<Card?> cards) in playedCardsPerPlayer)
        {
            int indexOfLastPlayedCard = cards.FindLastIndex(card => card != null);
            playsUntilAllCardsPlayed[player] = indexOfLastPlayedCard + 1;
        }

        playsUntilAllCardsPlayed = playsUntilAllCardsPlayed.ToDictionary(kvp => kvp.Key, kvp => kvp.Value * players.Count);

        currentPlayer = firstPlayer!;
        for (int i = 0; i < players.Count; ++i)
        {
            playsUntilAllCardsPlayed[currentPlayer] += i;
            currentPlayer = GameHelpers.Instance.GetNextPlayer(players, currentPlayer);
        }

        List<IPlayer> ranking = playsUntilAllCardsPlayed
            .OrderBy(kvp => kvp.Value)
            .Select(kvp => kvp.Key)
            .ToList();
        Dictionary<IPlayer, int> pointsInThisDeal = players.ToDictionary(player => player, player => 0);
        for (int i = 0; i < PointsPerRank.Count; ++i)
        {
            IPlayer playerWithPoints = ranking[i];
            int pointsForPlayer = PointsPerRank[i];
            pointsInThisDeal[playerWithPoints] = pointsForPlayer;
        }

        return pointsInThisDeal;
    }
}
