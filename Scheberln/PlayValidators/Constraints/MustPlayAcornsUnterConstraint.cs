using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint that the <see cref="Card"/>
/// with <see cref="Suit"/> <see cref="Suit.Acorns"/> and <see cref="Rank"/> <see cref="Rank.Unter"/> 
/// must be played if possible.
/// </summary>
public class MustPlayAcornsUnterConstraint : IConstraint
{
    
    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if ((cardThePlayerWantsToPlay?.Suit == Suit.Acorns) &&
            (cardThePlayerWantsToPlay?.Rank == Rank.Unter))
        {
            return true;
        }

        if (!currentPlayer.Cards.Any(card => (card.Suit == Suit.Acorns) &&
            (card.Rank == Rank.Unter)))
        {
            return true;
        }

        return false;
    }
}
