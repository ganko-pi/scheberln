using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.MustMatchSuitOfTrickConstraintTests;

public class IsFullfilled
{
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFirstCardInDealNoTricks_ReturnsTrue()
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
            CurrentObjective = Objective.NoTricks,
            Dealer = player3,
        };

        List<Card?> playedCards = [];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFirstCardInDealNoHearts_ReturnsTrue()
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
            CurrentObjective = Objective.NoHearts,
            Dealer = player3,
        };

        List<Card?> playedCards = [];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFirstCardInDealNoObers_ReturnsTrue()
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
            CurrentObjective = Objective.NoObers,
            Dealer = player3,
        };

        List<Card?> playedCards = [];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFirstCardInDealNoHeartsKing_ReturnsTrue()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFirstCardInSecondTrickOfDealNoTricks_ReturnsTrue()
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
            CurrentObjective = Objective.NoTricks,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player1;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Eight);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFirstCardInSecondTrickOfDealNoHearts_ReturnsTrue()
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
            CurrentObjective = Objective.NoHearts,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player1;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Eight);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFirstCardInSecondTrickOfDealNoObers_ReturnsTrue()
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
            CurrentObjective = Objective.NoObers,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player1;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Eight);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFirstCardInSecondTrickOfDealNoHeartsKing_ReturnsTrue()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player1;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Eight);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoTricksWithMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoTricks,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoHeartsWithMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoHearts,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoObersWithMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoObers,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoHeartsKingWithMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoTricksWithoutMatchingSuitButHasMatchingSuit_ReturnsFalse()
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
            CurrentObjective = Objective.NoTricks,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        currentPlayer.Cards.Add(new(Suit.Hearts, Rank.Seven));
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoHeartsWithoutMatchingSuitButHasMatchingSuit_ReturnsFalse()
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
            CurrentObjective = Objective.NoHearts,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        currentPlayer.Cards.Add(new(Suit.Hearts, Rank.Seven));
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoObersWithoutMatchingSuitButHasMatchingSuit_ReturnsFalse()
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
            CurrentObjective = Objective.NoObers,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        currentPlayer.Cards.Add(new(Suit.Hearts, Rank.Seven));
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoHeartsKingWithoutMatchingSuitButHasMatchingSuit_ReturnsFalse()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        currentPlayer.Cards.Add(new(Suit.Hearts, Rank.Seven));
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoTricksWithoutMatchingSuitAndHasNoMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoTricks,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoHeartsWithoutMatchingSuitAndHasNoMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoHearts,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoObersWithoutMatchingSuitAndHasNoMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoObers,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysSecondCardInSecondTrickOfDealNoHeartsKingWithoutMatchingSuitAndHasNoMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            new Card(Suit.Hearts, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player2;
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.Seven);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoTricksWithMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoTricks,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoHeartsWithMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoHearts,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoObersWithMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoObers,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoHeartsKingWithMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoTricksWithoutMatchingSuitButHasMatchingSuit_ReturnsFalse()
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
            CurrentObjective = Objective.NoTricks,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        currentPlayer.Cards.Add(new Card(Suit.Hearts, Rank.King));
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoHeartsWithoutMatchingSuitButHasMatchingSuit_ReturnsFalse()
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
            CurrentObjective = Objective.NoHearts,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        currentPlayer.Cards.Add(new Card(Suit.Hearts, Rank.King));
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoObersWithoutMatchingSuitButHasMatchingSuit_ReturnsFalse()
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
            CurrentObjective = Objective.NoObers,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        currentPlayer.Cards.Add(new Card(Suit.Hearts, Rank.King));
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoHeartsKingWithoutMatchingSuitButHasMatchingSuit_ReturnsFalse()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        currentPlayer.Cards.Add(new Card(Suit.Hearts, Rank.King));
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoTricksWithoutMatchingSuitAndHasNoMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoTricks,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoHeartsWithoutMatchingSuitAndHasNoMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoHearts,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoObersWithoutMatchingSuitAndHasNoMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoObers,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_PlayerPlaysFourthCardInSecondTrickOfDealNoHeartsKingWithoutMatchingSuitAndHasNoMatchingSuit_ReturnsTrue()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;
        
        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Bells, Rank.King);
        
        MustMatchSuitOfTrickConstraint mustMatchSuitOfTrickConstraint = new();

        // act
        bool actualResult = mustMatchSuitOfTrickConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
