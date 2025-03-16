using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// In interface representing a constraint if a play of a <see cref="Card"/> is allowed.
/// </summary>
public interface IConstraint
{
    /// <summary>
    /// Checks if the <see cref="IConstraint"/> is fullfilled.
    /// </summary>
    /// <param name="gameState">The state of a game before the play of <paramref name="cardThePlayerWantsToPlay"/>.</param>
    /// <param name="currentPlayer">The <see cref="IPlayer"/> who wants to play <paramref name="cardThePlayerWantsToPlay"/>.</param>
    /// <param name="cardThePlayerWantsToPlay">The <see cref="Card"/> the <paramref name="currentPlayer"/> wants to play.</param>
    /// <returns><see langword="true"/> if the <see cref="IConstraint"/> is fullfilled. <see langword="false"/> otherwise.</returns>
    bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay);
}
