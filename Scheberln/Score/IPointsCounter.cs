using System.Collections.Generic;

using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.Score;

/// <summary>
/// An interface representing a counter of points for a deal with a certain <see cref="Objective"/>.
/// </summary>
public interface IPointsCounter
{
    /// <summary>
    /// The <see cref="Objective"/> this class was implemented for.
    /// </summary>
    Objective Objective { get; }
    
    /// <summary>
    /// The points each trick of a <see cref="IPlayer"/> adds to his points.
    /// </summary>
    int PointsPerTrick { get; }

    /// <summary>
    /// Counts the points for each player in the last deal if it had the <see cref="Objective"/> this class was implemented for.
    /// </summary>
    /// <param name="gameState">The state of a game after a deal.</param>
    /// <returns>A <see cref="Dictionary{TKey, TValue}"/> with the points of each <see cref="IPlayer"/>.</returns>
    Dictionary<IPlayer, int> CountPointsAfterDeal(GameState gameState);
}
