using Scheberln.Cards;
using Scheberln.Players;
using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.HasNoUnterConstraintTests;

public class IsFullfilled
{

    [Test]
    public void TestIsFullfilled_WhenHavingNoUnter_ReturnsTrue()
    {
        // arrange
        IPlayer currentPlayer = new FakePlayer
        {
            Cards = [
                new Card(Suit.Acorns, Rank.Eight),
                new Card(Suit.Leaves, Rank.Ten),
                new Card(Suit.Bells, Rank.Ober),
            ]
        };

        HasNoUnterConstraint hasNoUnterConstraint = new();

        // act
        bool actualResult = hasNoUnterConstraint.IsFullfilled(null!, currentPlayer, null!);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFullfilled_WhenHavingUnter_ReturnsFalse()
    {
        // arrange
        IPlayer currentPlayer = new FakePlayer
        {
            Cards = [
                new Card(Suit.Acorns, Rank.Eight),
                new Card(Suit.Leaves, Rank.Unter),
                new Card(Suit.Bells, Rank.Ober),
            ]
        };

        HasNoUnterConstraint hasNoUnterConstraint = new();

        // act
        bool actualResult = hasNoUnterConstraint.IsFullfilled(null!, currentPlayer, null!);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
