using System.Collections.Generic;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

public class PlayConstraintFullfilledChecker : IPlayConstraintFullfilledChecker
{

    public bool AreAllPlayConstraintsFullfilled(List<IConstraint> playConstraints,
        GameState gameState,
        IPlayer currentPlayer,
        Card? cardThePlayerWantsToPlay)
    {
        foreach (IConstraint playConstraint in playConstraints)
        {
            if (!playConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay))
            {
                return false;
            }
        }

        return true;
    }
}
