using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.MustPlayAcornsUnterConstraintTests;

public class IsFullfilled
{

    [Test]
    public void TestIsFulfilled_WhenPlayingAcornsUnter_ReturnsTrue()
    {
        // arrange
        Card cardThePlayerWantsToPlay = new(Suit.Acorns, Rank.Unter);
        
        MustPlayAcornsUnterConstraint mustPlayAcornsUnterConstraint = new();

        // act
        bool actualResult = mustPlayAcornsUnterConstraint.IsFullfilled(null!, null!, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenNotPlayingAcornsUnterAndHasNoAcornsUnter_ReturnsTrue()
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
        
        MustPlayAcornsUnterConstraint mustPlayAcornsUnterConstraint = new();

        // act
        bool actualResult = mustPlayAcornsUnterConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_WhenNotPlayingAcornsUnterAndHasAcornsUnter_ReturnsFalse()
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
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Leaves, Rank.Ober),
        ];
        
        MustPlayAcornsUnterConstraint mustPlayAcornsUnterConstraint = new();

        // act
        bool actualResult = mustPlayAcornsUnterConstraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
