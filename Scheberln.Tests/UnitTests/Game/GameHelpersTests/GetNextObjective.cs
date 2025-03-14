using Scheberln.Game;

namespace Scheberln.Tests.UnitTests.Game.GameHelpersTests;

public class GetNextObjective
{

    [Test]
    public void TestGetNextObjective_WhenCalledWithNoTricks_ReturnsNoHearts()
    {
        // arrange
        Objective currentObjective = Objective.NoTricks;

        // act
        Objective nextObjective = GameHelpers.Instance.GetNextObjective(currentObjective);

        // assert
        Objective expectedObjective = Objective.NoHearts;
        Assert.That(nextObjective, Is.EqualTo(expectedObjective));
    }

    [Test]
    public void TestGetNextObjective_WhenCalledWithNoHearts_ReturnsNoObers()
    {
        // arrange
        Objective currentObjective = Objective.NoHearts;

        // act
        Objective nextObjective = GameHelpers.Instance.GetNextObjective(currentObjective);

        // assert
        Objective expectedObjective = Objective.NoObers;
        Assert.That(nextObjective, Is.EqualTo(expectedObjective));
    }

    [Test]
    public void TestGetNextObjective_WhenCalledWithNoObers_ReturnsNoHeartsKing()
    {
        // arrange
        Objective currentObjective = Objective.NoObers;

        // act
        Objective nextObjective = GameHelpers.Instance.GetNextObjective(currentObjective);

        // assert
        Objective expectedObjective = Objective.NoHeartsKing;
        Assert.That(nextObjective, Is.EqualTo(expectedObjective));
    }

    [Test]
    public void TestGetNextObjective_WhenCalledWithNoHeartsKing_ReturnsDomino()
    {
        // arrange
        Objective currentObjective = Objective.NoHeartsKing;

        // act
        Objective nextObjective = GameHelpers.Instance.GetNextObjective(currentObjective);

        // assert
        Objective expectedObjective = Objective.Domino;
        Assert.That(nextObjective, Is.EqualTo(expectedObjective));
    }

    [Test]
    public void TestGetNextObjective_WhenCalledWithDomino_ReturnsNoTricks()
    {
        // arrange
        Objective currentObjective = Objective.Domino;

        // act
        Objective nextObjective = GameHelpers.Instance.GetNextObjective(currentObjective);

        // assert
        Objective expectedObjective = Objective.NoTricks;
        Assert.That(nextObjective, Is.EqualTo(expectedObjective));
    }
}
