using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.HasNoAdjacentCardConstraintTests;

public class IsFullfilled
{

    [Test]
    public void TestIsFullfilled_WhenHavingNoAdjacentCard_ReturnsTrue()
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
        currentPlayer.Cards = [
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Bells, Rank.Ober),
        ];

        HasNoAdjacentCardConstraint hasNoAdjacentCardConstraint = new();

        // act
        bool actualResult = hasNoAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, null!);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenHavingUnter_ReturnsFalse()
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
        currentPlayer.Cards = [
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Bells, Rank.Ober),
        ];

        HasNoAdjacentCardConstraint hasNoAdjacentCardConstraint = new();

        // act
        bool actualResult = hasNoAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, null!);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
