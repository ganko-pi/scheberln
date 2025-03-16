using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;

namespace Scheberln.Tests.Fakes;

public class FakeFalseConstraint : IConstraint
{

    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        return false;
    }
}
