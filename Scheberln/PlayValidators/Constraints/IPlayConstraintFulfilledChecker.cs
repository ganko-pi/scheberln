using System.Collections.Generic;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// An interface representing a class for checking if all <see cref="IConstraint"/>s are fullfilled.
/// </summary>
public interface IPlayConstraintFullfilledChecker
{
    /// <summary>
    /// Checks if all <see cref="IConstraint"/>s are fullfilled.
    /// </summary>
    /// <param name="playConstraints">The <see cref="IConstraint"/>s to check if fullfilled.</param>
    /// <param name="gameState">The state of a game before the play of <paramref name="cardThePlayerWantsToPlay"/>.</param>
    /// <param name="currentPlayer">The <see cref="IPlayer"/> who wants to play <paramref name="cardThePlayerWantsToPlay"/>.</param>
    /// <param name="cardThePlayerWantsToPlay">The <see cref="Card"/> the <paramref name="currentPlayer"/> wants to play.</param>
    /// <returns><see langword="true"/> if all <see cref="IConstraint"/>s in <paramref name="playConstraints"/> are fullfilled. <see langword="false"/> otherwise.</returns>
    bool AreAllPlayConstraintsFullfilled(List<IConstraint> playConstraints,
        GameState gameState,
        IPlayer currentPlayer,
        Card? cardThePlayerWantsToPlay);
}
