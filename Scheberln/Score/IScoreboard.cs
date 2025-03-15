using System.Collections.Generic;

using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.Score;

/// <summary>
/// An interface representing a scoreboard to count the points of the players.
/// </summary>
public interface IScoreboard
{
    /// <summary>
    /// The points of the players.
    /// </summary>
    Dictionary<IPlayer, int> Points { get; }
    
    /// <summary>
    /// Updates the points of the players after a deal.
    /// </summary>
    /// <param name="gameState">The state of a game after a deal.</param>
    void UpdatePointsAfterDeal(GameState gameState);
}
