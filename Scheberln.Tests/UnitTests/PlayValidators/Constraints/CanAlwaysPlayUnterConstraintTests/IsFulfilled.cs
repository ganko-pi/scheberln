using Scheberln.Cards;
using Scheberln.PlayValidators.Constraints;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.CanAlwaysPlayUnterConstraintTests;

public class IsFulfilled
{
    
    [Test]
    public void TestIsFulfilled_WhenPlayingUnter_ReturnsTrue()
    {
        // arrange
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Unter);
        
        CanAlwaysPlayUnterConstraint canAlwaysPlayUnterConstraint = new();

        // act
        bool actualResult = canAlwaysPlayUnterConstraint.IsFullfilled(null!, null!, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFulfilled_WhenPlayingNoUnter_ReturnsFalse()
    {
        // arrange
        Card cardThePlayerWantsToPlay = new(Suit.Hearts, Rank.Seven);
        
        CanAlwaysPlayUnterConstraint canAlwaysPlayUnterConstraint = new();

        // act
        bool actualResult = canAlwaysPlayUnterConstraint.IsFullfilled(null!, null!, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsFulfilled_WhenPlayingNull_ReturnsFalse()
    {
        // arrange
        Card? cardThePlayerWantsToPlay = null;
        
        CanAlwaysPlayUnterConstraint canAlwaysPlayUnterConstraint = new();

        // act
        bool actualResult = canAlwaysPlayUnterConstraint.IsFullfilled(null!, null!, cardThePlayerWantsToPlay);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
