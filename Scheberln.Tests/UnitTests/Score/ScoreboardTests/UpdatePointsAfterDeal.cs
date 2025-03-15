using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.Score;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.Score.ScoreboardTests;

public class UpdatePointsAfterDeal
{
    
    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoTricksAndEmptyPointsDict_TracksPointsCorrectly()
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

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, -2 },
            { player1, -3 },
            { player2, -2 },
            { player3, -1 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoHeartsAndEmptyPointsDict_TracksPointsCorrectly()
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
            CurrentObjective = Objective.NoHearts,
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

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, -4 },
            { player1, -2 },
            { player2, 0 },
            { player3, -2 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoObersAndEmptyPointsDict_TracksPointsCorrectly()
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
            CurrentObjective = Objective.NoObers,
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

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, 0 },
            { player1, -4 },
            { player2, -4 },
            { player3, 0 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoHeartsKingAndEmptyPointsDict_TracksPointsCorrectly()
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
            CurrentObjective = Objective.NoHeartsKing,
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

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, -8 },
            { player1, 0 },
            { player2, 0 },
            { player3, 0 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveDominoAndEmptyPointsDict_TracksPointsCorrectly()
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

        Deck deck = new();

        GameState gameState = new(players, deck)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),

            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Acorns, Rank.Ace),
            new Card(Suit.Leaves, Rank.Ober),

            new Card(Suit.Hearts, Rank.Ober),
            null,
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Leaves, Rank.King),

            new Card(Suit.Hearts, Rank.King),
            null,
            new Card(Suit.Leaves, Rank.Ace),
            null,

            new Card(Suit.Hearts, Rank.Ace),
            null,
            new Card(Suit.Leaves, Rank.Ten),
            null,

            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Leaves, Rank.Nine),
            null,

            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Bells, Rank.Ober),
            null,

            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Leaves, Rank.Seven),
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Nine),

            null,
            new Card(Suit.Acorns, Rank.Nine),
            null,
            new Card(Suit.Bells, Rank.Eight),

            null,
            new Card(Suit.Acorns, Rank.Eight),
            null,
            new Card(Suit.Bells, Rank.Seven),

            null,
            new Card(Suit.Acorns, Rank.Seven),
            null,
            new Card(Suit.Bells, Rank.Ace),

            null,
            new Card(Suit.Hearts, Rank.Eight),
            null,
            new Card(Suit.Hearts, Rank.Seven),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, 20 },
            { player1, 4 },
            { player2, 8 },
            { player3, 0 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithNoObjective_ThrowsArgumentNullException()
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
            CurrentObjective = null,
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

        Scoreboard scoreboard = new();

        // act/assert
        ArgumentNullException thrownException = Assert.Throws<ArgumentNullException>(() => scoreboard.UpdatePointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("\"gameState.CurrentObjective\" passed to Scoreboard.UpdatePointsAfterDeal is null. (Parameter 'gameState.CurrentObjective')"));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoTricksAndFilledPointsDictAll0_TracksPointsCorrectly()
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

        Scoreboard scoreboard = new();
        scoreboard.Points.Add(player0, 0);
        scoreboard.Points.Add(player1, 0);
        scoreboard.Points.Add(player2, 0);
        scoreboard.Points.Add(player3, 0);

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, -2 },
            { player1, -3 },
            { player2, -2 },
            { player3, -1 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoTricksAndFilledPointsDictNot0_TracksPointsCorrectly()
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

        Scoreboard scoreboard = new();
        scoreboard.Points.Add(player0, -4);
        scoreboard.Points.Add(player1, -5);
        scoreboard.Points.Add(player2, -6);
        scoreboard.Points.Add(player3, -7);

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, -6 },
            { player1, -8 },
            { player2, -8 },
            { player3, -8 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoTricksAndPartiallyFilledPointssDict_TracksPointsCorrectly()
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

        Scoreboard scoreboard = new();
        scoreboard.Points.Add(player0, -4);
        scoreboard.Points.Add(player1, -5);

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, -6 },
            { player1, -8 },
            { player2, -2 },
            { player3, -1 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoTricksAndUnfinishedGameAndFinishedTrick_TracksPointsCorrectly()
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
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, -2 },
            { player1, -2 },
            { player2, 0 },
            { player3, -1 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoTricksAndUnfinishedGameAndUnfinishedTrick_ThrowsArgumentException()
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

            // trick 6 starts with player3
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => scoreboard.UpdatePointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoHeartsAndUnfinishedGameAndFinishedTrick_TracksPointsCorrectly()
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
            CurrentObjective = Objective.NoHearts,
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
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, -4 },
            { player1, -2 },
            { player2, 0 },
            { player3, -2 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoHeartsAndUnfinishedGameAndUnfinishedTrick_ThrowsArgumentException()
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
            CurrentObjective = Objective.NoHearts,
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

            // trick 6 starts with player3
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => scoreboard.UpdatePointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoObersAndUnfinishedGameAndFinishedTrick_TracksPointsCorrectly()
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
            CurrentObjective = Objective.NoObers,
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
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, 0 },
            { player1, -4 },
            { player2, 0 },
            { player3, 0 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoObersAndUnfinishedGameAndUnfinishedTrick_ThrowsArgumentException()
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
            CurrentObjective = Objective.NoObers,
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

            // trick 6 starts with player3
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Eight),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => scoreboard.UpdatePointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoHeartsKingAndUnfinishedGameAndFinishedTrickBeforeHeartsKing_TracksPointsCorrectly()
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
            CurrentObjective = Objective.NoHeartsKing,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            // trick 1 starts with player0 and is taken by player1
            new Card(Suit.Acorns, Rank.Eight),
            new Card(Suit.Acorns, Rank.Nine),
            new Card(Suit.Acorns, Rank.Seven),
            new Card(Suit.Hearts, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act
        scoreboard.UpdatePointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = scoreboard.Points;

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, 0 },
            { player1, 0 },
            { player2, 0 },
            { player3, 0 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveNoHeartsKingAndUnfinishedGameAndUnfinishedTrickBeforeHeartsKing_ThrowsArgumentException()
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
            CurrentObjective = Objective.NoHeartsKing,
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
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => scoreboard.UpdatePointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
    }

    [Test]
    public void TestUpdatePointsAfterDeal_WithObjectiveDominoAndUnfinishedGame_ThrowsArgumentException()
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

        Deck deck = new();

        GameState gameState = new(players, deck)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player3,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),

            new Card(Suit.Hearts, Rank.Unter),
            null,
            new Card(Suit.Acorns, Rank.Ace),
            new Card(Suit.Leaves, Rank.Ober),

            new Card(Suit.Hearts, Rank.Ober),
            null,
            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Leaves, Rank.King),

            new Card(Suit.Hearts, Rank.King),
            null,
            new Card(Suit.Leaves, Rank.Ace),
            null,

            new Card(Suit.Hearts, Rank.Ace),
            null,
            new Card(Suit.Leaves, Rank.Ten),
            null,

            new Card(Suit.Hearts, Rank.Ten),
            new Card(Suit.Hearts, Rank.Nine),
            new Card(Suit.Leaves, Rank.Nine),
            null,

            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Leaves, Rank.Eight),
            new Card(Suit.Bells, Rank.Ober),
            null,
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        Scoreboard scoreboard = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => scoreboard.UpdatePointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("The \"System.Collections.Generic.List`1[Scheberln.Cards.Card]\" passed to DominoPointsCounter.CountPointsAfterDeal in gameState.AllPlayedCardsInDeal does not contain all cards from \"Deck\"."));
    }
}
