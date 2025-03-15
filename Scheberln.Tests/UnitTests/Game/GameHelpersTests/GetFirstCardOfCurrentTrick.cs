using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.Game.GameHelpersTests;

public class GetFirstCardOfCurrentTrick
{
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndNoCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndOneCardIsPlayed_ReturnsFirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Seven);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndTwoCardsArePlayed_ReturnsFirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Seven);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndThreeCardsArePlayed_ReturnsFirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Seven);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndFourCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndFiveCardsArePlayed_ReturnsFifthCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Unter);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndFifteenCardsArePlayed_ReturnsThirteenthCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Hearts, Rank.Unter);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndSixteenCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndSeventeenCardsArePlayed_ReturnsSeventeenthCard()
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

        // act
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Leaves, Rank.Seven);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndThirtyoneCardsArePlayed_ReturnsTwentyninthCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Acorns, Rank.Unter);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndThirtytwoCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndNoCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndOneCardIsPlayed_ReturnsFirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Seven);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndTwoCardsArePlayed_ReturnsFirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Seven);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndThreeCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }

    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndFourCardsArePlayed_ReturnsFourthCard()
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

        // act
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Ten);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndFourteenCardsArePlayed_ReturnsThirteenthCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Hearts, Rank.Unter);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndFifteenCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndSixteenCardsArePlayed_ReturnsSixteenthCard()
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

        // act
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Hearts, Rank.Ace);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndThirtyoneCardsArePlayed_ReturnsThirtyfirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Acorns, Rank.King);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenThreePlayersAndThirtytwoCardsArePlayed_ReturnsThirtyfirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Acorns, Rank.King);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndNoCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndOneCardIsPlayed_ReturnsFirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Seven);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndFourCardsArePlayed_ReturnsFirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Seven);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndFiveCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndSixCardsArePlayed_ReturnsSixthCard()
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

        // act
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Bells, Rank.Ober);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndFourteenCardsArePlayed_ReturnsEleventhCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Hearts, Rank.Nine);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndFifteenCardsArePlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndSixteenCardsArePlayed_ReturnsSixteenthCard()
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

        // act
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Hearts, Rank.Ace);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndThirtyoneCardsArePlayed_ReturnsThirtyfirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Acorns, Rank.King);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFivePlayersAndThirtytwoCardsArePlayed_ReturnsThirtyfirstCard()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card expectedFirstCardOfCurrentTrick = new(Suit.Acorns, Rank.King);
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
    
    [Test]
    public void TestGetFirstCardOfCurrentTrick_WhenFourPlayersAndSixteenTimesNullIsPlayed_ReturnsNull()
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
        Card? firstCardOfCurrentTrick = GameHelpers.Instance.GetFirstCardOfCurrentTrick(gameState);

        // assert
        Card? expectedFirstCardOfCurrentTrick = null;
        Assert.That(firstCardOfCurrentTrick, Is.EqualTo(expectedFirstCardOfCurrentTrick));
    }
}
