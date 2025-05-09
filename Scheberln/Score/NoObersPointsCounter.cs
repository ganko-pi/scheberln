using System;
using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.Score;

/// <summary>
/// Implementation of <see cref="IPointsCounter"/> representing a counter of points for a deal with <see cref="Objective"/> <see cref="Objective.NoObers"/>.
/// </summary>
public class NoObersPointsCounter : IPointsCounter
{

    /// <inheritdoc/>
    public Objective Objective { get; } = Objective.NoObers;

    /// <inheritdoc/>
    public int PointsPerTrick { get; } = -2;

    /// <inheritdoc/>
    /// <exception cref="ArgumentException">
    /// Exception if passed objective in <paramref name="gameState"/> does not match <see cref="Objective"/>
    /// or if the passed cards in <paramref name="gameState"/> contain <see langword="null"/>.
    /// </exception>
    public Dictionary<IPlayer, int> CountPointsAfterDeal(GameState gameState)
    {
        Objective? currentObjective = gameState.CurrentObjective;
        if (currentObjective != Objective)
        {
            throw new ArgumentException($"The objective \"{currentObjective}\" passed to {nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.CurrentObjective)} does not match the objective \"{Objective}\" of class {nameof(NoObersPointsCounter)}.");
        }

        List<IPlayer> players = gameState.Players;
        Dictionary<IPlayer, int> pointsInThisDeal = players.ToDictionary(player => player, player => 0);

        List<Card?> allPlayedCardsInDeal = gameState.AllPlayedCardsInDeal;
        if (allPlayedCardsInDeal.Contains(null))
        {
            throw new ArgumentException($"The \"{allPlayedCardsInDeal.GetType()}\" passed to {nameof(NoObersPointsCounter)}.{nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.AllPlayedCardsInDeal)} does include null which is not valid for the objective \"{Objective}\".");
        }

        IPlayer? dealer = gameState.Dealer;
        if (dealer == null)
        {
            throw new ArgumentException($"Dealer in {nameof(NoObersPointsCounter)}.{nameof(CountPointsAfterDeal)} is null.");
        }

        IPlayer firstPlayer = GameHelpers.Instance.GetNextPlayer(players, dealer);

        for (int i = 0; i < gameState.AllPlayedCardsInDeal.Count; i += players.Count)
        {
            List<Card> cardsInTrick = allPlayedCardsInDeal.GetRange(i, players.Count)!;
            IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);
            int numberOfObersInTrick = cardsInTrick.Where(card => card.Rank == Rank.Ober).Count();
            pointsInThisDeal[playerWithTrick] += numberOfObersInTrick * PointsPerTrick;
            firstPlayer = playerWithTrick;
        }

        return pointsInThisDeal;
    }
}
