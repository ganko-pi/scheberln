using System;
using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.Score;

/// <summary>
/// Implementation of <see cref="IPointsCounter"/> representing a counter of points for a deal with <see cref="Objective"/> <see cref="Objective.NoTricks"/>.
/// </summary>
public class NoTricksPointsCounter : IPointsCounter
{

    /// <inheritdoc/>
    public Objective Objective { get; } = Objective.NoTricks;

    /// <inheritdoc/>
    public int PointsPerTrick { get; } = -1;

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
            throw new ArgumentException($"The objective \"{currentObjective}\" passed to {nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.CurrentObjective)} does not match the objective \"{Objective}\" of class {nameof(NoTricksPointsCounter)}.");
        }

        List<Card?> allPlayedCardsInDeal = gameState.AllPlayedCardsInDeal;
        if (allPlayedCardsInDeal.Contains(null))
        {
            throw new ArgumentException($"The \"{allPlayedCardsInDeal.GetType()}\" passed to {nameof(NoTricksPointsCounter)}.{nameof(CountPointsAfterDeal)} in {nameof(gameState)}.{nameof(GameState.AllPlayedCardsInDeal)} does include null which is not valid for the objective \"{Objective}\".");
        }

        List<IPlayer> playersWithTricks = GameHelpers.Instance.GetPlayersWithTricks(gameState);
        // Add all players again to have each player represented at least once and decrease the count by one.
        // Otherwise, players with no tricks are not in the resulting dictionary.
        playersWithTricks.AddRange(gameState.Players);
        Dictionary<IPlayer, int> pointsInThisDeal = playersWithTricks
            .GroupBy(player => player)
            .ToDictionary(group => group.Key, group => (group.Count() - 1) * PointsPerTrick);

        return pointsInThisDeal;
    }
}
