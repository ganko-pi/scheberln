using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.Score;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.Score.DominoPointsCounterTest;

public class CountPointsAfterDeal
{

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledWithValidGameStateAndFirstPlayerWithAcornsUnter_CountsPointsCorrectly()
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

        DominoPointsCounter dominoPointsCounter = new();

        // act
        Dictionary<IPlayer, int> actualPoints = dominoPointsCounter.CountPointsAfterDeal(gameState);

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
    public void TestCountPointsAfterDeal_WhenCalledWithValidGameStateAndThirdPlayerWithAcornsUnter_CountsPointsCorrectly()
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
            null,
            null,
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

        DominoPointsCounter dominoPointsCounter = new();

        // act
        Dictionary<IPlayer, int> actualPoints = dominoPointsCounter.CountPointsAfterDeal(gameState);

        // assert
        Dictionary<IPlayer, int> expectedPoints = new()
        {
            { player0, 8 },
            { player1, 0 },
            { player2, 20 },
            { player3, 4 },
        };

        Assert.That(actualPoints, Is.EquivalentTo(expectedPoints));
    }

    [Test]
    public void TestCountPointsAfterDealTwice_WhenCalledWithValidGameState_CountsPointsCorrectly()
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

        DominoPointsCounter dominoPointsCounter = new();

        // act
        dominoPointsCounter.CountPointsAfterDeal(gameState);
        Dictionary<IPlayer, int> actualPoints = dominoPointsCounter.CountPointsAfterDeal(gameState);

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
    public void TestCountPointsAfterDeal_WhenCalledWithWrongObjective_ThrowsArgumentException()
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
            CurrentObjective = Objective.NoTricks,
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

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("The objective \"NoTricks\" passed to CountPointsAfterDeal in gameState.CurrentObjective does not match the objective \"Domino\" of class DominoPointsCounter."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledWithNullObjective_ThrowsArgumentException()
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
            CurrentObjective = null,
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

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("The objective \"\" passed to CountPointsAfterDeal in gameState.CurrentObjective does not match the objective \"Domino\" of class DominoPointsCounter."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledWithTwoPlayers_ThrowsArgumentException()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        IPlayer player1 = new FakePlayer();
        List<IPlayer> players = [
            player0,
            player1,
        ];

        Deck deck = new();
        GameState gameState = new(players, deck)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player1,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ober),

            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),

            new Card(Suit.Hearts, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ace),

            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ober),

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
            new Card(Suit.Leaves, Rank.Eight),

            new Card(Suit.Acorns, Rank.Ten),
            new Card(Suit.Leaves, Rank.Seven),
            
            new Card(Suit.Bells, Rank.Ober),
            new Card(Suit.Acorns, Rank.Nine),

            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Acorns, Rank.Eight),
            
            new Card(Suit.Bells, Rank.Ten),
            new Card(Suit.Bells, Rank.Nine),

            null,
            new Card(Suit.Bells, Rank.Eight),
            
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

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("There are only 2 players passed to DominoPointsCounter.CountPointsAfterDeal in gameState.Players but at least 3 players are needed."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledWithThreePlayers_ThrowsArgumentException()
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

        Deck deck = new();
        GameState gameState = new(players, deck)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player2,
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

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("The \"System.Collections.Generic.List`1[Scheberln.Cards.Card]\" passed to DominoPointsCounter.CountPointsAfterDeal in gameState.AllPlayedCardsInDeal did not evenly distribute the cards to all players."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledWithFivePlayers_ThrowsArgumentException()
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
            player4,
        ];

        Deck deck = new();
        GameState gameState = new(players, deck)
        {
            CurrentObjective = Objective.Domino,
            Dealer = player4,
        };

        List<Card?> playedCards = [
            new Card(Suit.Acorns, Rank.Unter),
            new Card(Suit.Acorns, Rank.Ober),
            new Card(Suit.Acorns, Rank.King),
            new Card(Suit.Leaves, Rank.Unter),
            new Card(Suit.Hearts, Rank.Unter),

            null,
            null,
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ober),
            new Card(Suit.Acorns, Rank.Ace),

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

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("The \"System.Collections.Generic.List`1[Scheberln.Cards.Card]\" passed to DominoPointsCounter.CountPointsAfterDeal in gameState.AllPlayedCardsInDeal did not evenly distribute the cards to all players."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledWithNullDealer_ThrowsArgumentException()
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
            Dealer = null,
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

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Dealer in DominoPointsCounter.CountPointsAfterDeal is null."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledWithDealerNotInPlayers_ThrowsArgumentException()
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

        Deck deck = new();
        GameState gameState = new(players, deck)
        {
            CurrentObjective = Objective.Domino,
            Dealer = dealer,
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

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("Scheberln.Tests.Fakes.FakePlayer Scheberln.Tests.Fakes.FakePlayer in GameHelpers.GetNextPlayer is not part of players."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledBeforeAllCardsArePlayedButArePlayedEvenly_ThrowsArgumentException()
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
            new Card(Suit.Acorns, Rank.Ace),
            new Card(Suit.Leaves, Rank.Ober),
            new Card(Suit.Hearts, Rank.Ober),

            new Card(Suit.Bells, Rank.Unter),
            new Card(Suit.Leaves, Rank.King),
            new Card(Suit.Hearts, Rank.King),
            new Card(Suit.Leaves, Rank.Ace),
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("The \"System.Collections.Generic.List`1[Scheberln.Cards.Card]\" passed to DominoPointsCounter.CountPointsAfterDeal in gameState.AllPlayedCardsInDeal does not contain all cards from \"Deck\"."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledBeforeAllCardsArePlayedButArePlayedUnevenly_ThrowsArgumentException()
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
        ];

        gameState.AllPlayedCardsInDeal = playedCards;

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("The \"System.Collections.Generic.List`1[Scheberln.Cards.Card]\" passed to DominoPointsCounter.CountPointsAfterDeal in gameState.AllPlayedCardsInDeal does not contain all cards from \"Deck\"."));
    }

    [Test]
    public void TestCountPointsAfterDeal_WhenCalledWithUnevenlyDistributedCards_ThrowsArgumentException()
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
            new Card(Suit.Bells, Rank.Ten),

            new Card(Suit.Bells, Rank.King),
            new Card(Suit.Leaves, Rank.Seven),
            null,
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

        DominoPointsCounter dominoPointsCounter = new();

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => dominoPointsCounter.CountPointsAfterDeal(gameState));

        Assert.That(thrownException.Message, Is.EqualTo("The \"System.Collections.Generic.List`1[Scheberln.Cards.Card]\" passed to DominoPointsCounter.CountPointsAfterDeal in gameState.AllPlayedCardsInDeal did not evenly distribute the cards to all players."));
    }
}
