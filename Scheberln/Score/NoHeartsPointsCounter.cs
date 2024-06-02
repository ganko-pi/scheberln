using System;
using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.Score;

/// <summary>
/// Implementation of <see cref="IPointsCounter"/> representing a counter of points for a deal with <see cref="Objective"/> <see cref="Objective.NoHearts"/>.
/// </summary>
public class NoHeartsPointsCounter : IPointsCounter
{

    /// <inheritdoc/>
    public Objective Objective { get; } = Objective.NoHearts;

    /// <inheritdoc/>
    public int PointsPerTrick { get; } = -1;

    /// <inheritdoc/>
    /// <exception cref="ArgumentException">Exception if passed objective in <paramref name="gameState"/> does not match <see cref="Objective"/>.</exception>
    public Dictionary<IPlayer, int> CountPointsAfterDeal(GameState gameState)
    {
        Objective? currentObjective = gameState.CurrentObjective;
        if (currentObjective != Objective)
        {
            throw new ArgumentException($"The objective \"{currentObjective}\" passed to {nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.CurrentObjective)} does not match the objective \"{Objective}\" of class {nameof(NoHeartsPointsCounter)}.");
        }

        List<IPlayer> players = gameState.Players;
        Dictionary<IPlayer, int> pointsInThisDeal = players.ToDictionary(player => player, player => 0);

        List<Card> allPlayedCardsInDeal = gameState.AllPlayedCardsInDeal;
        IPlayer? dealer = gameState.Dealer;
        if (dealer == null)
        {
            throw new ArgumentException($"Dealer in {nameof(NoHeartsPointsCounter)}.{nameof(CountPointsAfterDeal)} is null.");
        }

        IPlayer firstPlayer = GameHelpers.Instance.GetNextPlayer(players, dealer);

        for (int i = 0; i < gameState.AllPlayedCardsInDeal.Count; i += players.Count)
        {
            List<Card> cardsInTrick = allPlayedCardsInDeal.GetRange(i, players.Count);
            IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);
            int numberOfHeartsInTrick = cardsInTrick.Where(card => card.Suit == Suit.Hearts).Count();
            pointsInThisDeal[playerWithTrick] += numberOfHeartsInTrick * PointsPerTrick;
            firstPlayer = playerWithTrick;
        }

        return pointsInThisDeal;
    }
}
