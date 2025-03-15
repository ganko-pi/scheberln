using System;
using System.Collections.Generic;

using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.Score;

/// <summary>
/// Implementation of <see cref="IScoreboard"/> representing a scoreboard to count the points of the players.
/// </summary>
public class Scoreboard : IScoreboard
{
    private readonly Dictionary<Objective, IPointsCounter> _pointsCounters = new();

    /// <inheritdoc/>
    public Dictionary<IPlayer, int> Points { get; } = new();

    /// <summary>
    /// Creates a new <see cref="Scoreboard"/> without any players in <see cref="Points"/>.
    /// </summary>
    public Scoreboard()
    {
        _pointsCounters.Add(Objective.NoTricks, new NoTricksPointsCounter());
        _pointsCounters.Add(Objective.NoHearts, new NoHeartsPointsCounter());
        _pointsCounters.Add(Objective.NoObers, new NoObersPointsCounter());
        _pointsCounters.Add(Objective.NoHeartsKing, new NoHeartsKingPointsCounter());
        _pointsCounters.Add(Objective.Domino, new DominoPointsCounter());
    }
    
    /// <inheritdoc/>
    public void UpdatePointsAfterDeal(GameState gameState)
    {
        Objective? currentObjective = gameState.CurrentObjective;
        if (currentObjective == null)
        {
            throw new ArgumentNullException("gameState.CurrentObjective", $"\"{nameof(gameState)}.{nameof(GameState.CurrentObjective)}\" passed to {nameof(Scoreboard)}.{nameof(UpdatePointsAfterDeal)} is null.");
        }
        
        Dictionary<IPlayer, int> pointsInThisDeal = _pointsCounters[(Objective)currentObjective].CountPointsAfterDeal(gameState);
        foreach (KeyValuePair<IPlayer, int> playerPointsInThisDeal in pointsInThisDeal)
        {
            IPlayer player = playerPointsInThisDeal.Key;
            int playerPoints = playerPointsInThisDeal.Value;
            Points.TryAdd(player, 0);
            Points[player] += playerPoints;
        }
    }
}
