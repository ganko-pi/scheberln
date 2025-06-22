using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.MustPlayAdjacentCardConstraintTests;

public class IsFullfilled
{
    
    [Test]
    public void TestIsFullfilled_WhenPlayingLowerAdjacentCard_ReturnsTrue()
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

        GameState gameState = new(players, null!)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Nine);
        
        MustPlayAdjacentCardConstraint mustPlayAdjacentCardConstraint = new();

        // act
        bool actualResult = mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
        
        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_WhenPlayingHigherAdjacentCard_ReturnsTrue()
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

        GameState gameState = new(players, null!)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.King);
        
        MustPlayAdjacentCardConstraint mustPlayAdjacentCardConstraint = new();

        // act
        bool actualResult = mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
        
        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_WhenPlayingCardOneHigherThanLowestCardOfSuit_ReturnsFalse()
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

        GameState gameState = new(players, null!)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Ten);
        
        MustPlayAdjacentCardConstraint mustPlayAdjacentCardConstraint = new();

        // act
        bool actualResult = mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
        
        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_WhenPlayingCardOneLowerThanHighestCardOfSuit_ReturnsFalse()
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

        GameState gameState = new(players, null!)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Unter);
        
        MustPlayAdjacentCardConstraint mustPlayAdjacentCardConstraint = new();

        // act
        bool actualResult = mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
        
        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_WhenSuitOfPlayedCardWasNotPlayedAlready_ReturnsFalse()
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

        GameState gameState = new(players, null!)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Leaves, Rank.Unter);
        
        MustPlayAdjacentCardConstraint mustPlayAdjacentCardConstraint = new();

        // act
        bool actualResult = mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
        
        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_WhenPlayingCardTwoLowerThanLowestCardOfSuit_ReturnsFalse()
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

        GameState gameState = new(players, null!)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Seven);
        
        MustPlayAdjacentCardConstraint mustPlayAdjacentCardConstraint = new();

        // act
        bool actualResult = mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
        
        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_WhenPlayingCardTwoHigherThanHighestCardOfSuit_ReturnsFalse()
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

        GameState gameState = new(players, null!)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Ace);
        
        MustPlayAdjacentCardConstraint mustPlayAdjacentCardConstraint = new();

        // act
        bool actualResult = mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
        
        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_WhenPlayingNull_ReturnsFalse()
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

        GameState gameState = new(players, null!)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card? cardThePlayerWantsToPlay = null;
        
        MustPlayAdjacentCardConstraint mustPlayAdjacentCardConstraint = new();

        // act
        bool actualResult = mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);
        
        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
