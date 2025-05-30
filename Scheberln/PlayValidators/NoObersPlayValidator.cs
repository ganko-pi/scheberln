using System.Collections.Generic;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;

namespace Scheberln.PlayValidators;

/// <summary>
/// Implementation of <see cref="IPlayValidator"/> representing a validator if a play is allowed for a deal with <see cref="Objective"/> <see cref="Objective.NoObers"/>.
/// </summary>
public class NoObersPlayValidator : IPlayValidator
{
    private readonly IPlayConstraintFullfilledChecker _playConstraintFullfilledChecker;

    /// <inheritdoc/>
    public List<IConstraint> PlayConstraints { get; } = new()
    {
        new NoNullCardPlayConstraint(),
        new PlayerMustHaveCardPlayConstraint(),
        new MustMatchSuitOfTrickConstraint(),
    };

    /// <summary>
    /// Constructor for <see cref="NoObersPlayValidator"/>.
    /// </summary>
    /// <param name="playConstraintFullfilledChecker">Class for checking if all <see cref="IConstraint"/>s are fullfilled.</param>
    public NoObersPlayValidator(IPlayConstraintFullfilledChecker playConstraintFullfilledChecker)
    {
        _playConstraintFullfilledChecker = playConstraintFullfilledChecker;
    }

    /// <inheritdoc/>
    public bool IsValidCardToPlay(GameState gameState, IPlayer currentPlayer, Card cardThePlayerWantsToPlay)
    {
        return _playConstraintFullfilledChecker.AreAllPlayConstraintsFullfilled(PlayConstraints,
            gameState,
            currentPlayer,
            cardThePlayerWantsToPlay);
    }
}
