using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint the playing of a <see cref="Card"/> is allowed
/// when it is not <see langword="null"/>.
/// </summary>
public class NoNullCardConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        return cardThePlayerWantsToPlay != null;
    }
}
