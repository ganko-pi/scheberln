using Scheberln.PlayValidators.Constraints;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.PlayValidators.Constraints.AndConstraintTests;

public class IsFullfilled
{
    
    [Test]
    public void TestIsFulfilled_NoConstraints_ReturnsTrue()
    {
        // arrange
        AndConstraint andConstraint = new();

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_OneTrueConstraint_ReturnsTrue()
    {
        // arrange
        FakeTrueConstraint trueConstraint0 = new();
        AndConstraint andConstraint = new(trueConstraint0);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_OneFalseConstraint_ReturnsFalse()
    {
        // arrange
        FakeFalseConstraint falseConstraint0 = new();
        AndConstraint andConstraint = new(falseConstraint0);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_TwoTrueConstraints_ReturnsTrue()
    {
        // arrange
        FakeTrueConstraint trueConstraint0 = new();
        FakeTrueConstraint trueConstraint1 = new();
        AndConstraint andConstraint = new(trueConstraint0, trueConstraint1);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_FirstTrueThenFalseConstraint_ReturnsFalse()
    {
        // arrange
        FakeTrueConstraint trueConstraint0 = new();
        FakeFalseConstraint falseConstraint0 = new();
        AndConstraint andConstraint = new(trueConstraint0, falseConstraint0);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_FirstFalseThenTrueConstraint_ReturnsFalse()
    {
        // arrange
        FakeTrueConstraint trueConstraint0 = new();
        FakeFalseConstraint falseConstraint0 = new();
        AndConstraint andConstraint = new(falseConstraint0, trueConstraint0);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_TwoFalseConstraints_ReturnsFalse()
    {
        // arrange
        FakeFalseConstraint falseConstraint0 = new();
        FakeFalseConstraint falseConstraint1 = new();
        AndConstraint andConstraint = new(falseConstraint0, falseConstraint1);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_EightTrueConstraints_ReturnsTrue()
    {
        // arrange
        FakeTrueConstraint trueConstraint0 = new();
        FakeTrueConstraint trueConstraint1 = new();
        FakeTrueConstraint trueConstraint2 = new();
        FakeTrueConstraint trueConstraint3 = new();
        FakeTrueConstraint trueConstraint4 = new();
        FakeTrueConstraint trueConstraint5 = new();
        FakeTrueConstraint trueConstraint6 = new();
        FakeTrueConstraint trueConstraint7 = new();
        AndConstraint andConstraint = new(trueConstraint0, trueConstraint1, trueConstraint2, trueConstraint3, trueConstraint4, trueConstraint5, trueConstraint6, trueConstraint7);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = true;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_OneFalseAtFirstSevenTrueConstraints_ReturnsFalse()
    {
        // arrange
        FakeTrueConstraint trueConstraint0 = new();
        FakeTrueConstraint trueConstraint1 = new();
        FakeTrueConstraint trueConstraint2 = new();
        FakeTrueConstraint trueConstraint3 = new();
        FakeTrueConstraint trueConstraint4 = new();
        FakeTrueConstraint trueConstraint5 = new();
        FakeTrueConstraint trueConstraint6 = new();
        FakeFalseConstraint falseConstraint0 = new();
        AndConstraint andConstraint = new(falseConstraint0, trueConstraint0, trueConstraint1, trueConstraint2, trueConstraint3, trueConstraint4, trueConstraint5, trueConstraint6);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_OneFalseAtSecondSevenTrueConstraints_ReturnsFalse()
    {
        // arrange
        FakeTrueConstraint trueConstraint0 = new();
        FakeTrueConstraint trueConstraint1 = new();
        FakeTrueConstraint trueConstraint2 = new();
        FakeTrueConstraint trueConstraint3 = new();
        FakeTrueConstraint trueConstraint4 = new();
        FakeTrueConstraint trueConstraint5 = new();
        FakeTrueConstraint trueConstraint6 = new();
        FakeFalseConstraint falseConstraint0 = new();
        AndConstraint andConstraint = new(trueConstraint0, falseConstraint0, trueConstraint1, trueConstraint2, trueConstraint3, trueConstraint4, trueConstraint5, trueConstraint6);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_OneFalseAtEighthSevenTrueConstraints_ReturnsFalse()
    {
        // arrange
        FakeTrueConstraint trueConstraint0 = new();
        FakeTrueConstraint trueConstraint1 = new();
        FakeTrueConstraint trueConstraint2 = new();
        FakeTrueConstraint trueConstraint3 = new();
        FakeTrueConstraint trueConstraint4 = new();
        FakeTrueConstraint trueConstraint5 = new();
        FakeTrueConstraint trueConstraint6 = new();
        FakeFalseConstraint falseConstraint0 = new();
        AndConstraint andConstraint = new(trueConstraint0, trueConstraint1, trueConstraint2, trueConstraint3, trueConstraint4, trueConstraint5, trueConstraint6, falseConstraint0);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestIsFulfilled_EightFalseConstraints_ReturnsFalse()
    {
        // arrange
        FakeFalseConstraint falseConstraint0 = new();
        FakeFalseConstraint falseConstraint1 = new();
        FakeFalseConstraint falseConstraint2 = new();
        FakeFalseConstraint falseConstraint3 = new();
        FakeFalseConstraint falseConstraint4 = new();
        FakeFalseConstraint falseConstraint5 = new();
        FakeFalseConstraint falseConstraint6 = new();
        FakeFalseConstraint falseConstraint7 = new();
        AndConstraint andConstraint = new(falseConstraint0, falseConstraint1, falseConstraint2, falseConstraint3, falseConstraint4, falseConstraint5, falseConstraint6, falseConstraint7);

        // act
        bool actualResult = andConstraint.IsFullfilled(null!, null!, null);

        // assert
        bool expectedResult = false;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
