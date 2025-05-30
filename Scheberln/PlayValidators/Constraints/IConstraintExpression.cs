using System;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

public interface IConstraintExpression
{
    Func<GameState, IPlayer, Card?, bool> Func { get; }

    bool Evaluate(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay);

    IConstraintExpression Not();

    IConstraintExpression And(IConstraintExpression constraintExpression);

    IConstraintExpression Or(IConstraintExpression constraintExpression);
}
