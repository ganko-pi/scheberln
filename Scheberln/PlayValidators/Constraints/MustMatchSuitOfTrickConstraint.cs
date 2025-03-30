using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint the playing of a <see cref="Card"/> is allowed
/// when it is the first card of a trick,
/// its suit matches the suit of the first <see cref="Card"/> in the trick
/// or the <see cref="IPlayer"/> does not have a <see cref="Card"/> with the suit of the first <see cref="Card"/> in the trick.
/// </summary>
public class MustMatchSuitOfTrickConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);
        if (firstCardOfCurrentTrick == null)
        {
            return true;
        }
        
        if (cardThePlayerWantsToPlay?.Suit == firstCardOfCurrentTrick.Suit)
        {
            return true;
        }
        
        if (!currentPlayer.Cards.Any(card => card.Suit == firstCardOfCurrentTrick.Suit))
        {
            return true;
        }

        return false;
    }
}
