using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.MustPlayOberWhenNoMatchingSuitConstraintTests;

public class IsFullfilled
{

    [Test]
    public void TestIsFulfilled_WhenPlayingOber_ReturnsTrue()
    {
        // arrange
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Ober);
        
        MustPlayOberWhenNoMatchingSuitConstraint mustPlayOberWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayOberWhenNoMatchingSuitConstraint.IsFullfilled(null!, null!, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenPlayingSuitOfTrickAndHasNoOber_ReturnsTrue()
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
            new Card(Suit.Acorns, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        currentPlayer.Cards = [
            cardThePlayerWantsToPlay,
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Leaves, Rank.Unter),
        ];
        
        MustPlayOberWhenNoMatchingSuitConstraint mustPlayOberWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayOberWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenPlayingSuitOfTrickAndHasOber_ReturnsTrue()
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
            new Card(Suit.Acorns, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        currentPlayer.Cards = [
            cardThePlayerWantsToPlay,
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayOberWhenNoMatchingSuitConstraint mustPlayOberWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayOberWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenNotPlayingSuitOfTrickAndHasNoOber_ReturnsTrue()
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
            new Card(Suit.Leaves, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        currentPlayer.Cards = [
            cardThePlayerWantsToPlay,
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Leaves, Rank.Unter),
        ];
        
        MustPlayOberWhenNoMatchingSuitConstraint mustPlayOberWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayOberWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenNotPlayingSuitOfTrickAndHasOber_ReturnsFalse()
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
            new Card(Suit.Leaves, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        currentPlayer.Cards = [
            cardThePlayerWantsToPlay,
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayOberWhenNoMatchingSuitConstraint mustPlayOberWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayOberWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenPlayingNoOberAsFirstCard_ReturnsTrue()
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
        currentPlayer.Cards = [
            cardThePlayerWantsToPlay,
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayOberWhenNoMatchingSuitConstraint mustPlayOberWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayOberWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenPlayingNullAndHasNoOber_ReturnsTrue()
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
            new Card(Suit.Acorns, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card? cardThePlayerWantsToPlay = null;
        currentPlayer.Cards = [
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Leaves, Rank.Unter),
        ];
        
        MustPlayOberWhenNoMatchingSuitConstraint mustPlayOberWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayOberWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenPlayingNullAndHasOber_ReturnsFalse()
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
            new Card(Suit.Acorns, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card? cardThePlayerWantsToPlay = null;
        currentPlayer.Cards = [
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayOberWhenNoMatchingSuitConstraint mustPlayOberWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayOberWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
