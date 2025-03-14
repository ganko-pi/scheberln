using Scheberln.Cards;
using Scheberln.Players;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.Cards.DeckTests;

public class DealCards
{

    [Test]
    public void TestDealCards_WhenCalledWithKnownRandom_PlayersHaveExpectedCards()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
        ];

        Random random = new(0);
        Deck deck = new();

        // act
        deck.DealAllCards(players, random);

        // assert
        List<Card> expectedCardsPlayer0 = [
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.Ace),
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Ace),
        ];

        Assert.That(player0.Cards, Is.EqualTo(expectedCardsPlayer0));

        List<Card> expectedCardsPlayer1 = [
            new Card(Suit.Bells, Rank.Nine),
            new Card(Suit.Bells, Rank.Ace),
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Unter),
        ];

        Assert.That(player1.Cards, Is.EqualTo(expectedCardsPlayer1));
        
        List<Card> expectedCardsPlayer2 = [
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Acorns, Rank.King),
        ];

        Assert.That(player2.Cards, Is.EqualTo(expectedCardsPlayer2));
        
        List<Card> expectedCardsPlayer3 = [
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ace),
            new Card(Suit.Leaves, Rank.Seven),
        ];

        Assert.That(player3.Cards, Is.EqualTo(expectedCardsPlayer3));
    }

    [Test]
    public void TestDealCardsTwice_WhenCalledWithKnownRandom_PlayersHaveExpectedCards()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
        ];

        Deck deck = new();

        // act
        Random random = new(0);
        deck.DealAllCards(players, random);
        players.ForEach(player =>
        {
            deck.AddCards(player.Cards);
            player.Cards.Clear();
        });
        random = new(0);
        deck.DealAllCards(players, random);

        // assert
        List<Card> expectedCardsPlayer0 = [
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.Ace),
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Ace),
        ];

        Assert.That(player0.Cards, Is.EqualTo(expectedCardsPlayer0));

        List<Card> expectedCardsPlayer1 = [
            new Card(Suit.Bells, Rank.Nine),
            new Card(Suit.Bells, Rank.Ace),
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Unter),
        ];

        Assert.That(player1.Cards, Is.EqualTo(expectedCardsPlayer1));
        
        List<Card> expectedCardsPlayer2 = [
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Acorns, Rank.King),
        ];

        Assert.That(player2.Cards, Is.EqualTo(expectedCardsPlayer2));
        
        List<Card> expectedCardsPlayer3 = [
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ace),
            new Card(Suit.Leaves, Rank.Seven),
        ];

        Assert.That(player3.Cards, Is.EqualTo(expectedCardsPlayer3));
    }

    [Test]
    public void TestDealCardsTwice_SecondTimeWhenNotAllCardsBackWithKnownRandom_PlayersHaveExpectedCards()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
        ];

        Deck deck = new();

        // act
        Random random = new(0);
        deck.DealAllCards(players, random);
        players.ForEach(player =>
        {
            deck.AddCards(player.Cards[..3]);
            player.Cards.RemoveRange(0, 3);
        });
        random = new(0);
        deck.DealAllCards(players, random);

        // assert
        List<Card> expectedCardsPlayer0 = [
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.Ace),
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Ace),
        ];

        Assert.That(player0.Cards, Is.EqualTo(expectedCardsPlayer0));

        List<Card> expectedCardsPlayer1 = [
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Unter),
        ];

        Assert.That(player1.Cards, Is.EqualTo(expectedCardsPlayer1));
        
        List<Card> expectedCardsPlayer2 = [
            new Card(Suit.Bells, Rank.Nine),
            new Card(Suit.Bells, Rank.Ace),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Acorns, Rank.King),
        ];

        Assert.That(player2.Cards, Is.EqualTo(expectedCardsPlayer2));
        
        List<Card> expectedCardsPlayer3 = [
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ace),
            new Card(Suit.Leaves, Rank.Seven),
        ];

        Assert.That(player3.Cards, Is.EqualTo(expectedCardsPlayer3));
    }
}
