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
}
