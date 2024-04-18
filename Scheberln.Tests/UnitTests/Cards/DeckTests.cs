using Scheberln.Cards;

namespace Scheberln.Tests.UnitTests.Cards.DeckTests;

public class DeckTests
{

    [Test]
    public void TestConstructor_WhenCalled_CardDeckIsCreated()
    {
        // act
        Deck deck = new();

        // assert
        List<Card> expectedCards = [
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Bells, Rank.Nine),
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Bells, Rank.Ace),
            
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Hearts, Rank.Ace),
            
            new Card(Suit.Leaves, Rank.Seven),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Leaves, Rank.Ace),
            
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Acorns, Rank.Ace),
        ];

        Assert.That(deck.Cards, Is.EqualTo(expectedCards));
    }
}
