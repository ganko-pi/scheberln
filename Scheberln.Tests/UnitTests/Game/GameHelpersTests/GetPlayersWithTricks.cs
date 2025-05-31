using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.Game.GameHelpersTests;

public class GetPlayersWithTricks
{

    [Test]
    public void TestGetPlayersWithTricks_WhenCalledWithFullDeal_ReturnsCorrectPlayers()
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
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.King),

            // trick 3 starts with player0 and is taken by player0
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Seven),

            // trick 4 starts with player0 and is taken by player1
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Hearts, Rank.Ober),

            // trick 5 starts with player1 and is taken by player3
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ace),

            // trick 6 starts with player3 and is taken by player1
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Bells, Rank.Nine),

            // trick 7 starts with player1 and is taken by player2
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Bells, Rank.Ace),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Bells, Rank.King),

            // trick 8 starts with player2 and is taken by player2
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Leaves, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        // act
        List<IPlayer> playersWithTricks = GameHelpers.Instance.GetPlayersWithTricks(gameState);

        // assert
        List<IPlayer> expectedPlayersWithTricks = [
            player1,
            player0,
            player0,
            player1,
            player3,
            player1,
            player2,
            player2,
        ];
        Assert.That(playersWithTricks, Is.EquivalentTo(expectedPlayersWithTricks));
    }

    [Test]
    public void TestGetPlayersWithTricks_WhenCalledWithThreePlayersAndFullDeal_ThrowsArgumentException()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
        ];

        GameState gameState = new(players, null!)
        {
            Dealer = player2,
        };

        List<Card?> playedCards = [
            // trick 1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),

            // trick 2
            new Card(Suit.Hearts, Rank.Ace),
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            
            // trick 3
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ten),
            
            // trick 4
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Seven),

            // trick 5
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),
            
            // trick 6
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Acorns, Rank.King),
            
            // trick 7
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ace),
            new Card(Suit.Bells, Rank.Ten),
            
            // trick 8
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Bells, Rank.Nine),

            // trick 9
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Bells, Rank.Ace),
            new Card(Suit.Acorns, Rank.Ober),
            
            // trick 10
            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ten),
            
            // trick 11
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Leaves, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.GetPlayersWithTricks(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
    }

    [Test]
    public void TestGetPlayersWithTricks_WhenCalledWithFivePlayers_ThrowsArgumentException()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer player4 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
            player4
        ];

        GameState gameState = new(players, null!)
        {
            Dealer = player4,
        };

        List<Card?> playedCards = [
            // trick 1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),
            new Card(Suit.Hearts, Rank.Eight),
            
            // trick 2
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            
            // trick 3
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Seven),
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),
            
            // trick 4
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ace),
            
            // trick 5
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Bells, Rank.Nine),
            new Card(Suit.Bells, Rank.Ober),
            
            // trick 6
            new Card(Suit.Bells, Rank.Ace),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ten),
            
            // trick 7
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Leaves, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.GetPlayersWithTricks(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
    }

    [Test]
    public void TestGetPlayersWithTricks_WhenCalledWithNullDealer_ThrowsArgumentException()
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
            Dealer = null,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.King),

            // trick 3 starts with player0 and is taken by player0
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Seven),

            // trick 4 starts with player0 and is taken by player1
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Hearts, Rank.Ober),

            // trick 5 starts with player1 and is taken by player3
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ace),

            // trick 6 starts with player3 and is taken by player1
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Bells, Rank.Nine),

            // trick 7 starts with player1 and is taken by player2
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Bells, Rank.Ace),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Bells, Rank.King),

            // trick 8 starts with player2 and is taken by player2
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Leaves, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.GetPlayersWithTricks(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Dealer in GameHelpers.GetPlayersWithTricks is null."));
    }

    [Test]
    public void TestGetPlayersWithTricks_WhenCalledWithDealerNotInPlayers_ThrowsArgumentException()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        IPlayer player2 = new FakePlayer();
        IPlayer player3 = new FakePlayer();
        IPlayer dealer = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
            player2,
            player3,
        ];

        GameState gameState = new(players, null!)
        {
            Dealer = dealer,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.King),

            // trick 3 starts with player0 and is taken by player0
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Seven),

            // trick 4 starts with player0 and is taken by player1
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Hearts, Rank.Ober),

            // trick 5 starts with player1 and is taken by player3
            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ace),

            // trick 6 starts with player3 and is taken by player1
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Eight),
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Bells, Rank.Nine),

            // trick 7 starts with player1 and is taken by player2
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Bells, Rank.Ace),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Bells, Rank.King),

            // trick 8 starts with player2 and is taken by player2
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Bells, Rank.Seven),
            new Card(Suit.Leaves, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.GetPlayersWithTricks(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Scheberln.Tests.Fakes.FakePlayer Scheberln.Tests.Fakes.FakePlayer in GameHelpers.GetNextPlayer is not part of players."));
    }

    [Test]
    public void TestGetPlayersWithTricks_WhenCalledBeforeAllCardsArePlayed_CountsPointsCorrectly()
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
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),

            // trick 2 starts with player1 and is taken by player0
            new Card(Suit.Hearts, Rank.Eight),
            new Card(Suit.Hearts, Rank.Seven),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Hearts, Rank.King),

            // trick 3 starts with player0 and is taken by player0
            new Card(Suit.Leaves, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Leaves, Rank.Nine),
            new Card(Suit.Leaves, Rank.Seven),

            // trick 4 starts with player0 and is taken by player1
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Hearts, Rank.Ober),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        // act
        List<IPlayer> playersWithTricks = GameHelpers.Instance.GetPlayersWithTricks(gameState);

        // assert
        List<IPlayer> expectedPlayersWithTricks = [
            player1,
            player0,
            player0,
            player1,
        ];
        Assert.That(playersWithTricks, Is.EquivalentTo(expectedPlayersWithTricks));
    }
}
