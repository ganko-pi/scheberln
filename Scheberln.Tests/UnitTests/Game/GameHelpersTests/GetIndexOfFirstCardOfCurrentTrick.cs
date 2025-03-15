using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.Game.GameHelpersTests;

public class GetIndexOfFirstCardOfCurrentTrick
{
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndNoCardsArePlayed_Returns0()
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
        
        GameState gameState = new(players, deck);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndOneCardIsPlayed_Returns0()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndTwoCardsArePlayed_Returns0()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndThreeCardsArePlayed_Returns0()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndFourCardsArePlayed_Returns4()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 4;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndFiveCardsArePlayed_Returns4()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 4;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndFifteenCardsArePlayed_Returns12()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 12;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndSixteenCardsArePlayed_Returns16()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);
        Card card15 = new(Suit.Hearts, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card15);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 16;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndThirtyoneCardsArePlayed_Returns28()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);
        Card card15 = new(Suit.Hearts, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card15);
        Card card16 = new(Suit.Leaves, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card16);
        Card card17 = new(Suit.Leaves, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card17);
        Card card18 = new(Suit.Leaves, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card18);
        Card card19 = new(Suit.Leaves, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card19);
        Card card20 = new(Suit.Leaves, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card20);
        Card card21 = new(Suit.Leaves, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card21);
        Card card22 = new(Suit.Leaves, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card22);
        Card card23 = new(Suit.Leaves, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card23);
        Card card24 = new(Suit.Acorns, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card24);
        Card card25 = new(Suit.Acorns, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card25);
        Card card26 = new(Suit.Acorns, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card26);
        Card card27 = new(Suit.Acorns, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card27);
        Card card28 = new(Suit.Acorns, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card28);
        Card card29 = new(Suit.Acorns, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card29);
        Card card30 = new(Suit.Acorns, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card30);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 28;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndThirtytwoCardsArePlayed_Returns32()
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
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);
        Card card15 = new(Suit.Hearts, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card15);
        Card card16 = new(Suit.Leaves, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card16);
        Card card17 = new(Suit.Leaves, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card17);
        Card card18 = new(Suit.Leaves, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card18);
        Card card19 = new(Suit.Leaves, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card19);
        Card card20 = new(Suit.Leaves, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card20);
        Card card21 = new(Suit.Leaves, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card21);
        Card card22 = new(Suit.Leaves, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card22);
        Card card23 = new(Suit.Leaves, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card23);
        Card card24 = new(Suit.Acorns, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card24);
        Card card25 = new(Suit.Acorns, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card25);
        Card card26 = new(Suit.Acorns, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card26);
        Card card27 = new(Suit.Acorns, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card27);
        Card card28 = new(Suit.Acorns, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card28);
        Card card29 = new(Suit.Acorns, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card29);
        Card card30 = new(Suit.Acorns, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card30);
        Card card31 = new(Suit.Acorns, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card31);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 32;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenThreePlayersAndNoCardsArePlayed_Returns0()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenThreePlayersAndOneCardIsPlayed_Returns0()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenThreePlayersAndTwoCardsArePlayed_Returns0()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }

    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenThreePlayersAndThreeCardsArePlayed_Returns3()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 3;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenThreePlayersAndFourteenCardsArePlayed_Returns12()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 12;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }

    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenThreePlayersAndFifteenCardsArePlayed_Returns15()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 15;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenThreePlayersAndThirtyoneCardsArePlayed_Returns30()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);
        Card card15 = new(Suit.Hearts, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card15);
        Card card16 = new(Suit.Leaves, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card16);
        Card card17 = new(Suit.Leaves, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card17);
        Card card18 = new(Suit.Leaves, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card18);
        Card card19 = new(Suit.Leaves, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card19);
        Card card20 = new(Suit.Leaves, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card20);
        Card card21 = new(Suit.Leaves, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card21);
        Card card22 = new(Suit.Leaves, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card22);
        Card card23 = new(Suit.Leaves, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card23);
        Card card24 = new(Suit.Acorns, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card24);
        Card card25 = new(Suit.Acorns, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card25);
        Card card26 = new(Suit.Acorns, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card26);
        Card card27 = new(Suit.Acorns, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card27);
        Card card28 = new(Suit.Acorns, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card28);
        Card card29 = new(Suit.Acorns, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card29);
        Card card30 = new(Suit.Acorns, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card30);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 30;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenThreePlayersAndThirtytwoCardsArePlayed_Returns30()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);
        Card card15 = new(Suit.Hearts, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card15);
        Card card16 = new(Suit.Leaves, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card16);
        Card card17 = new(Suit.Leaves, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card17);
        Card card18 = new(Suit.Leaves, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card18);
        Card card19 = new(Suit.Leaves, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card19);
        Card card20 = new(Suit.Leaves, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card20);
        Card card21 = new(Suit.Leaves, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card21);
        Card card22 = new(Suit.Leaves, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card22);
        Card card23 = new(Suit.Leaves, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card23);
        Card card24 = new(Suit.Acorns, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card24);
        Card card25 = new(Suit.Acorns, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card25);
        Card card26 = new(Suit.Acorns, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card26);
        Card card27 = new(Suit.Acorns, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card27);
        Card card28 = new(Suit.Acorns, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card28);
        Card card29 = new(Suit.Acorns, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card29);
        Card card30 = new(Suit.Acorns, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card30);
        Card card31 = new(Suit.Acorns, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card31);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 30;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFivePlayersAndNoCardsArePlayed_Returns0()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFivePlayersAndOneCardIsPlayed_Returns0()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFivePlayersAndFourCardsArePlayed_Returns0()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 0;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }

    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFivePlayersAndFiveCardsArePlayed_Returns5()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 5;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFivePlayersAndFourteenCardsArePlayed_Returns10()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 10;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }

    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFivePlayersAndFifteenCardsArePlayed_Returns15()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 15;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFivePlayersAndThirtyoneCardsArePlayed_Returns30()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);
        Card card15 = new(Suit.Hearts, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card15);
        Card card16 = new(Suit.Leaves, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card16);
        Card card17 = new(Suit.Leaves, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card17);
        Card card18 = new(Suit.Leaves, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card18);
        Card card19 = new(Suit.Leaves, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card19);
        Card card20 = new(Suit.Leaves, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card20);
        Card card21 = new(Suit.Leaves, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card21);
        Card card22 = new(Suit.Leaves, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card22);
        Card card23 = new(Suit.Leaves, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card23);
        Card card24 = new(Suit.Acorns, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card24);
        Card card25 = new(Suit.Acorns, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card25);
        Card card26 = new(Suit.Acorns, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card26);
        Card card27 = new(Suit.Acorns, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card27);
        Card card28 = new(Suit.Acorns, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card28);
        Card card29 = new(Suit.Acorns, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card29);
        Card card30 = new(Suit.Acorns, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card30);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 30;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFivePlayersAndThirtytwoCardsArePlayed_Returns30()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4,
        ];
        
        Deck deck = new();
        
        GameState gameState = new(players, deck);

        Card card0 = new(Suit.Bells, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card card1 = new(Suit.Bells, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card card2 = new(Suit.Bells, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card card3 = new(Suit.Bells, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card card4 = new(Suit.Bells, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card card5 = new(Suit.Bells, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card card6 = new(Suit.Bells, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card card7 = new(Suit.Bells, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card card8 = new(Suit.Hearts, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card card9 = new(Suit.Hearts, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card card10 = new(Suit.Hearts, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card card11 = new(Suit.Hearts, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card card12 = new(Suit.Hearts, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card card13 = new(Suit.Hearts, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card card14 = new(Suit.Hearts, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card14);
        Card card15 = new(Suit.Hearts, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card15);
        Card card16 = new(Suit.Leaves, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card16);
        Card card17 = new(Suit.Leaves, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card17);
        Card card18 = new(Suit.Leaves, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card18);
        Card card19 = new(Suit.Leaves, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card19);
        Card card20 = new(Suit.Leaves, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card20);
        Card card21 = new(Suit.Leaves, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card21);
        Card card22 = new(Suit.Leaves, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card22);
        Card card23 = new(Suit.Leaves, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card23);
        Card card24 = new(Suit.Acorns, Rank.Seven);
        gameState.AllPlayedCardsInDeal.Add(card24);
        Card card25 = new(Suit.Acorns, Rank.Eight);
        gameState.AllPlayedCardsInDeal.Add(card25);
        Card card26 = new(Suit.Acorns, Rank.Nine);
        gameState.AllPlayedCardsInDeal.Add(card26);
        Card card27 = new(Suit.Acorns, Rank.Ten);
        gameState.AllPlayedCardsInDeal.Add(card27);
        Card card28 = new(Suit.Acorns, Rank.Unter);
        gameState.AllPlayedCardsInDeal.Add(card28);
        Card card29 = new(Suit.Acorns, Rank.Ober);
        gameState.AllPlayedCardsInDeal.Add(card29);
        Card card30 = new(Suit.Acorns, Rank.King);
        gameState.AllPlayedCardsInDeal.Add(card30);
        Card card31 = new(Suit.Acorns, Rank.Ace);
        gameState.AllPlayedCardsInDeal.Add(card31);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 30;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetIndexOfFirstCardOfCurrentTrick_WhenFourPlayersAndSixteenTimesNullIsPlayed_Returns16()
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
        
        GameState gameState = new(players, deck);

        Card? card0 = null;
        gameState.AllPlayedCardsInDeal.Add(card0);
        Card? card1 = null;
        gameState.AllPlayedCardsInDeal.Add(card1);
        Card? card2 = null;
        gameState.AllPlayedCardsInDeal.Add(card2);
        Card? card3 = null;
        gameState.AllPlayedCardsInDeal.Add(card3);
        Card? card4 = null;
        gameState.AllPlayedCardsInDeal.Add(card4);
        Card? card5 = null;
        gameState.AllPlayedCardsInDeal.Add(card5);
        Card? card6 = null;
        gameState.AllPlayedCardsInDeal.Add(card6);
        Card? card7 = null;
        gameState.AllPlayedCardsInDeal.Add(card7);
        Card? card8 = null;
        gameState.AllPlayedCardsInDeal.Add(card8);
        Card? card9 = null;
        gameState.AllPlayedCardsInDeal.Add(card9);
        Card? card10 = null;
        gameState.AllPlayedCardsInDeal.Add(card10);
        Card? card11 = null;
        gameState.AllPlayedCardsInDeal.Add(card11);
        Card? card12 = null;
        gameState.AllPlayedCardsInDeal.Add(card12);
        Card? card13 = null;
        gameState.AllPlayedCardsInDeal.Add(card13);
        Card? card14 = null;
        gameState.AllPlayedCardsInDeal.Add(card14);
        Card? card15 = null;
        gameState.AllPlayedCardsInDeal.Add(card15);

        // act
        int indexOfFirstCardOfCurrentTrick = GameHelpers.Instance.GetIndexOfFirstCardOfCurrentTrick(gameState);

        // assert
        int expectedIndexOfFirstCardOfCurrentTrick = 16;
        Assert.That(indexOfFirstCardOfCurrentTrick, Is.EqualTo(expectedIndexOfFirstCardOfCurrentTrick));
    }
}
