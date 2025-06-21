using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint a <see cref="Card"/> with
/// <see cref="Rank"/> <see cref="Rank.Ober"/> must be played if an <see cref="IPlayer"/> has no <see cref="Card"/>
/// matching the <see cref="Suit"/> of the trick and has cards with <see cref="Rank"/> <see cref="Rank.Ober"/>.
/// </summary>
public class MustPlayOberWhenNoMatchingSuitConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if (cardThePlayerWantsToPlay?.Rank == Rank.Ober)
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
        
        if (!currentPlayer.Cards.Any(card => card.Rank == Rank.Ober))
        {
            return true;
        }

        return false;
    }
}
