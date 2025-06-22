using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.MustPlayHeartsKingWhenNoMatchingSuitConstraintTests;

public class IsFullfilled
{

    [Test]
    public void TestIsFullfilled_WhenPlayingHeartsKing_ReturnsTrue()
    {
        // arrange
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.King);
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(null!, null!, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenPlayingSuitOfTrickOtherThanHeartsAndHasNoHeartsKing_ReturnsTrue()
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
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenPlayingSuitOfTrickOtherThanHeartsAndHasHeartsKing_ReturnsTrue()
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
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenNotPlayingSuitOfTrickOtherThanHeartsAndHasNoHeartsKing_ReturnsTrue()
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
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenNotPlayingSuitOfTrickOtherThanHeartsAndHasHeartsKing_ReturnsFalse()
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
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenPlayingHeartsAsSuitOfTrickAndHasNoHeartsKing_ReturnsTrue()
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
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Eight);
        currentPlayer.Cards = [
            cardThePlayerWantsToPlay,
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenPlayingHeartsAsSuitOfTrickAndHasHeartsKing_ReturnsTrue()
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
            new Card(Suit.Hearts, Rank.Nine),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        IPlayer currentPlayer = player0;
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Eight);
        currentPlayer.Cards = [
            cardThePlayerWantsToPlay,
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenPlayingNoHeartsKingAsFirstCard_ReturnsTrue()
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
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenPlayingNullAndHasNoHeartsKing_ReturnsTrue()
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
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenPlayingNullAndHasHeartsKing_ReturnsFalse()
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
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayHeartsKingWhenNoMatchingSuitConstraint mustPlayHeartsKingWhenNoMatchingSuitConstraint = new();

        // act
        bool actualResult = mustPlayHeartsKingWhenNoMatchingSuitConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
