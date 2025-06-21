using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint the playing of a <see cref="Card"/> is allowed
/// when it is <see langword="null"/> or
/// the <see cref="IPlayer"/> has the <see cref="Card"/>.
/// </summary>
public class MustHaveCardConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if (cardThePlayerWantsToPlay == null)
        {
            return true;
        }

        return currentPlayer.Cards.Contains(cardThePlayerWantsToPlay);
    }
}
