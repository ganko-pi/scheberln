using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint a <see cref="Card"/> with
/// <see cref="Suit"/> <see cref="Suit.Hearts"/> must be played if an <see cref="IPlayer"/> has no <see cref="Card"/>
/// matching the <see cref="Suit"/> of the trick but does have cards with <see cref="Suit"/> <see cref="Suit.Hearts"/>.
/// </summary>
public class MustPlayHeartsWhenNoMatchingSuitConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if (cardThePlayerWantsToPlay?.Suit == Suit.Hearts)
        {
            return true;
        }

        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);
        if (firstCardOfCurrentTrick == null)
        {
            return true;
        }
        
        if (cardThePlayerWantsToPlay?.Suit == firstCardOfCurrentTrick.Suit)
        {
            return true;
        }
        
        if (!currentPlayer.Cards.Any(card => card.Suit == Suit.Hearts))
        {
            return true;
        }

        return false;
    }
}
