using Scheberln.Cards;
using Scheberln.PlayValidators.Constraints;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.MustPlayCardConstraintTests;

public class IsFullfilled
{
    
    [Test]
    public void TestIsFullfilled_CardIsNotNull_ReturnsTrue()
    {
        // arrange
        MustPlayCardConstraint mustPlayCardConstraint = new();
        Card card = new(Suit.Bells, Rank.Seven);

        // act
        bool actualResult = mustPlayCardConstraint.IsFullfilled(null!, null!, card);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFullfilled_CardIsNull_ReturnsFalse()
    {
        // arrange
        MustPlayCardConstraint mustPlayCardConstraint = new();

        // act
        bool actualResult = mustPlayCardConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
