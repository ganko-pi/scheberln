using Scheberln.Game;
using Scheberln.Players;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.Game.GameHelpersTests;

public class GetNextPlayer
{

    [Test]
    public void TestGetNextPlayer_WhenCalledWithValidArguments_ReturnsCorrectNextPlayer()
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

        IPlayer currentPlayer = player1;

        // act
        IPlayer nextPlayer = GameHelpers.Instance.GetNextPlayer(players, currentPlayer);

        // assert
        IPlayer expectedPlayer = player2;
        Assert.That(nextPlayer, Is.SameAs(expectedPlayer));
    }
    
    [Test]
    public void TestGetNextPlayer_WhenCalledWithLastPlayerInList_ReturnsFirstPlayerInList()
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

        IPlayer currentPlayer = player3;

        // act
        IPlayer nextPlayer = GameHelpers.Instance.GetNextPlayer(players, currentPlayer);

        // assert
        IPlayer expectedPlayer = player0;
        Assert.That(nextPlayer, Is.SameAs(expectedPlayer));
    }
    
    [Test]
    public void TestGetNextPlayer_WhenCalledWithEmptyList_ThrowsArgumentException()
    {
        // arrange
        List<IPlayer> players = [];

        IPlayer currentPlayer = new FakePlayer();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.GetNextPlayer(players, currentPlayer));

        Assert.That(thrownException.Message, Is.EqualTo("Scheberln.Tests.Fakes.FakePlayer Scheberln.Tests.Fakes.FakePlayer in GameHelpers.GetNextPlayer is not part of players."));
    }
    
    [Test]
    public void TestGetNextPlayer_WhenCalledWithPlayerNotInList_ThrowsArgumentException()
    {
        // arrange
        List<IPlayer> players = [];

        IPlayer currentPlayer = new FakePlayer();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.GetNextPlayer(players, currentPlayer));

        Assert.That(thrownException.Message, Is.EqualTo("Scheberln.Tests.Fakes.FakePlayer Scheberln.Tests.Fakes.FakePlayer in GameHelpers.GetNextPlayer is not part of players."));
    }
    
    [Test]
    public void TestGetNextPlayer_WhenCalledWithOnlyOnePlayerInList_ReturnsSamePlayer()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        List<IPlayer> players = [
            player0,
        ];

        IPlayer currentPlayer = player0;

        // act
        IPlayer nextPlayer = GameHelpers.Instance.GetNextPlayer(players, currentPlayer);

        // assert
        IPlayer expectedPlayer = player0;
        Assert.That(nextPlayer, Is.SameAs(expectedPlayer));
    }
}
