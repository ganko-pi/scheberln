using System.Collections.Generic;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;

namespace Scheberln.PlayValidators;

/// <summary>
/// In interface representing a validator if a play is allowed for a deal with a certain <see cref="Objective"/>.
/// </summary>
public interface IPlayValidator
{
    /// <summary>
    /// The <see cref="IConstraint"/>s to fullfill to play a valid card.
    /// </summary>
    List<IConstraint> PlayConstraints { get; }

    /// <summary>
    /// Checks if <paramref name="currentPlayer"/> playing the <paramref name="cardThePlayerWantsToPlay"/> is allowed for the current <paramref name="gameState"/>.
    /// </summary>
    /// <param name="gameState">The state of a game before the play of <paramref name="cardThePlayerWantsToPlay"/>.</param>
    /// <param name="currentPlayer">The <see cref="IPlayer"/> who wants to play <paramref name="cardThePlayerWantsToPlay"/>.</param>
    /// <param name="cardThePlayerWantsToPlay">The <see cref="Card"/> the <paramref name="currentPlayer"/> wants to play.</param>
    /// <returns><see langword="true"/> if the play is allowed. <see langword="false"/> otherwise.</returns>
    bool IsValidCardToPlay(GameState gameState, IPlayer currentPlayer, Card cardThePlayerWantsToPlay);
}
