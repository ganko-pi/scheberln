using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.MustHaveCardConstraintTests;

public class IsFullfilled
{
    
    [Test]
    public void TestIsFulfilled_PlayerHasCard_ReturnsTrue()
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
        currentPlayer.Cards = [
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.King),
        ];
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        
        MustHaveCardConstraint mustHaveCardConstraint = new();

        // act
        bool actualResult = mustHaveCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_PlayerDoesNotHaveCard_ReturnsFalse()
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
        currentPlayer.Cards = [
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Acorns, Rank.King),
        ];
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Eight);
        
        MustHaveCardConstraint mustHaveCardConstraint = new();

        // act
        bool actualResult = mustHaveCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_CardIsNull_ReturnsTrue()
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
        Card? cardThePlayerWantsToPlay = null;
        
        MustHaveCardConstraint mustHaveCardConstraint = new();

        // act
        bool actualResult = mustHaveCardConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
