using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint that only adjacent
/// <see cref="Card"/>s of the currently played cards can be played.
/// </summary>
public class MustPlayAdjacentCardConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if (cardThePlayerWantsToPlay == null)
        {
            return false;
        }

        Suit suitOfPlayerCard = cardThePlayerWantsToPlay.Suit;
        Rank rankOfPlayerCard = cardThePlayerWantsToPlay.Rank;

        IEnumerable<Card> playedCardsWithSuitOfPlayerCard = gameState.AllPlayedCardsInDeal.Where(card => card?.Suit == suitOfPlayerCard)!;
        if (!playedCardsWithSuitOfPlayerCard.Any())
        {
            return false;
        }

        Card lowestPlayedCardWithSuitOfPlayerCard = playedCardsWithSuitOfPlayerCard.MinBy(card => card.Rank)!;
        if ((lowestPlayedCardWithSuitOfPlayerCard.Rank - rankOfPlayerCard) == 1)
        {
            return true;
        }
        
        Card highestPlayedCardWithSuitOfPlayerCard = playedCardsWithSuitOfPlayerCard.MaxBy(card => card.Rank)!;
        if ((highestPlayedCardWithSuitOfPlayerCard.Rank - rankOfPlayerCard) == -1)
        {
            return true;
        }

        return false;
    }
}
