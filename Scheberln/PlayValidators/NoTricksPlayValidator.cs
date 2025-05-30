using System.Collections.Generic;
using System.Linq.Expressions;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;

namespace Scheberln.PlayValidators;

/// <summary>
/// Implementation of <see cref="IPlayValidator"/> representing a validator if a play is allowed for a deal with <see cref="Objective"/> <see cref="Objective.NoTricks"/>.
/// </summary>
public class NoTricksPlayValidator : IPlayValidator
{
    private readonly IPlayConstraintFullfilledChecker _playConstraintFullfilledChecker;

    /// <inheritdoc/>
    public IConstraintExpression ConstraintExpression =
        new ConstraintExpression(new NoNullCardPlayConstraint())
        .And(new ConstraintExpression(new PlayerMustHaveCardPlayConstraint()))
        .And(new ConstraintExpression(new MustMatchSuitOfTrickConstraint()));

    /// <summary>
    /// Constructor for <see cref="NoTricksPlayValidator"/>.
    /// </summary>
    /// <param name="playConstraintFullfilledChecker">Class for checking if all <see cref="IConstraint"/>s are fullfilled.</param>
    public NoTricksPlayValidator(IPlayConstraintFullfilledChecker playConstraintFullfilledChecker)
    {
        _playConstraintFullfilledChecker = playConstraintFullfilledChecker;
    }

    public List<IConstraint> PlayConstraints => throw new System.NotImplementedException();

    /// <inheritdoc/>
    public bool IsValidCardToPlay(GameState gameState, IPlayer currentPlayer, Card cardThePlayerWantsToPlay)
    {
        return ConstraintExpression.Evaluate(gameState,
            currentPlayer,
            cardThePlayerWantsToPlay);
    }
}
