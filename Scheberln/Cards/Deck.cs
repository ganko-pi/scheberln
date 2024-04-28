using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Scheberln.Players;

namespace Scheberln.Cards;

/// <summary>
/// A class representing a card deck.
/// </summary>
public class Deck
{
    private readonly List<Card> _cards;

    /// <summary>
    /// The cards in a deck which do currently not belong to an <see cref="IPlayer"/>.
    /// </summary>
    public ReadOnlyCollection<Card> Cards
    {
        get => _cards.AsReadOnly();
    }

    /// <summary>
    /// Creates a new card deck consisting of one card of each combination of <see cref="Suit"/>s and <see cref="Rank"/>s.
    /// </summary>
    public Deck()
    {
        Suit[] suitValues = Enum.GetValues<Suit>();
        Rank[] rankValues = Enum.GetValues<Rank>();

        int numberOfCards = suitValues.Length * rankValues.Length;

        _cards = new List<Card>(numberOfCards);
        foreach (Suit suit in suitValues)
        {
            foreach (Rank rank in rankValues)
            {
                _cards.Add(new Card(suit, rank));
            }
        }
    }

    /// <summary>
    /// Deals all cards which do currently not belong to an <see cref="IPlayer"/> evenly to the given <paramref name="players"/>.
    /// </summary>
    /// <param name="players">The <see cref="IPlayer"/>s the cards are dealt to.</param>
    /// <param name="random">An optional <see cref="Random"/> to make the dealing foreseeable for testing.</param>
    public void DealAllCards(List<IPlayer> players, Random? random = null)
    {
        random ??= Random.Shared;

        SortCardsAscending();

        int currentPlayerIndex = 0;

        int cardsCount = _cards.Count;
        for (int cardsAvailable = cardsCount; cardsAvailable > 0; --cardsAvailable)
        {
            int cardIndex = random.Next(cardsAvailable);
            Card card = _cards[cardIndex];
            _cards.RemoveAt(cardIndex);

            players[currentPlayerIndex].Cards.Add(card);

            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
        }
    }

    private void SortCardsAscending()
    {
        _cards.Sort((cardA, cardB) => cardA.Suit.CompareTo(cardB.Suit) * 2 + cardA.Rank.CompareTo(cardB.Rank));
    }

    /// <summary>
    /// Adds the given cards back to the deck.
    /// </summary>
    /// <param name="cards">The cards to add to the deck.</param>
    public void AddCards(List<Card> cards)
    {
        _cards.AddRange(cards);
    }
}
