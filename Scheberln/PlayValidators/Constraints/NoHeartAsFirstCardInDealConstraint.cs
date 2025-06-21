using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint the playing of a <see cref="Card"/> is allowed
/// when it is not the first <see cref="Card"/> in a deal or
/// it is the first <see cref="Card"/> in the deal but not <see cref="Suit.Hearts"/>.
/// </summary>
public class NoHeartsAsFirstCardInDealConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        List<Card?> allPlayedCardsInDeal = gameState.AllPlayedCardsInDeal;
        if (allPlayedCardsInDeal.Any())
        {
            return true;
        }

        if (cardThePlayerWantsToPlay?.Suit != Suit.Hearts)
        {
            return true;
        }

        return false;
    }
}
