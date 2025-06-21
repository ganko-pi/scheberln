using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint the <see cref="Card"/> with
/// <see cref="Suit"/> <see cref="Suit.Hearts"/> and <see cref="Rank"/> <see cref="Rank.Ober"/> must be
/// played if an <see cref="IPlayer"/> has no <see cref="Card"/> matching the <see cref="Suit"/> of the
/// trick and has the <see cref="Card"/>.
/// </summary>
public class MustPlayHeartsKingWhenNoMatchingSuitConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if ((cardThePlayerWantsToPlay?.Suit == Suit.Hearts) &&
            (cardThePlayerWantsToPlay?.Rank == Rank.King))
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
        
        if (!currentPlayer.Cards.Any(card => (card.Suit == Suit.Hearts) &&
            (card.Rank == Rank.King)))
        {
            return true;
        }

        return false;
    }
}
