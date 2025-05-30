using System;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

public class ConstraintExpression : IConstraintExpression
{

    public Func<GameState, IPlayer, Card?, bool> Func { get; }
    
    public ConstraintExpression(IConstraint playConstraint)
    {
        Func = (gameState, currentPlayer, cardThePlayerWantsToPlay) => playConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
    }

    private ConstraintExpression(Func<GameState, IPlayer, Card?, bool> newFunc)
    {
        Func = newFunc;
    }

    public bool Evaluate(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        return Func.Invoke(gameState, currentPlayer, cardThePlayerWantsToPlay);
    }

    public IConstraintExpression Not()
    {
        bool InvertedFunc(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
        {
            return !Func.Invoke(gameState, currentPlayer, cardThePlayerWantsToPlay);
        }

        return new ConstraintExpression(InvertedFunc);
    }

    public IConstraintExpression And(IConstraintExpression constraintExpression)
    {
        bool AndedFuncs(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
        {
            return Func.Invoke(gameState, currentPlayer, cardThePlayerWantsToPlay) && constraintExpression.Func.Invoke(gameState, currentPlayer, cardThePlayerWantsToPlay);
        }

        return new ConstraintExpression(AndedFuncs);
    }

    public IConstraintExpression Or(IConstraintExpression constraintExpression)
    {
        bool OredFuncs(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
        {
            return Func.Invoke(gameState, currentPlayer, cardThePlayerWantsToPlay) || constraintExpression.Func.Invoke(gameState, currentPlayer, cardThePlayerWantsToPlay);
        }

        return new ConstraintExpression(OredFuncs);
    }
}
