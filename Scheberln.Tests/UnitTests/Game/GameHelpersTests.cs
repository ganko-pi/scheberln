using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.Tests.Fakes;

namespace Scheberln.Tests.UnitTests.Game;

public class GameHelpersTests
{
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithAllCardsOfOneColorAndFirstPlayerPlaysHighestCard_ReturnsFirstPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Ober);
        Card card1 = new(Suit.Bells, Rank.Unter);
        Card card2 = new(Suit.Bells, Rank.Seven);
        Card card3 = new(Suit.Bells, Rank.Ten);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player1;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithAllCardsOfOneColorAndSecondPlayerPlaysHighestCard_ReturnsSecondPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Unter);
        Card card1 = new(Suit.Bells, Rank.Ober);
        Card card2 = new(Suit.Bells, Rank.Seven);
        Card card3 = new(Suit.Bells, Rank.Ten);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player2;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithAllCardsOfOneColorAndLastPlayerPlaysHighestCard_ReturnsLastPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Unter);
        Card card1 = new(Suit.Bells, Rank.Seven);
        Card card2 = new(Suit.Bells, Rank.Ten);
        Card card3 = new(Suit.Bells, Rank.Ober);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player0;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }

    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithCardsOfDifferentColorsAndFirstPlayerPlaysHighestCard_ReturnsFirstPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Unter);
        Card card1 = new(Suit.Acorns, Rank.Ober);
        Card card2 = new(Suit.Hearts, Rank.Ace);
        Card card3 = new(Suit.Leaves, Rank.Ten);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player1;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithCardsOfDifferentColorsAndSecondPlayerPlaysHighestCard_ReturnsSecondPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Unter);
        Card card1 = new(Suit.Bells, Rank.Ober);
        Card card2 = new(Suit.Acorns, Rank.Ace);
        Card card3 = new(Suit.Hearts, Rank.Ace);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player2;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithCardsOfDifferentColorsAndLastPlayerPlaysHighestCard_ReturnsLastPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Seven);
        Card card1 = new(Suit.Leaves, Rank.Ober);
        Card card2 = new(Suit.Leaves, Rank.Seven);
        Card card3 = new(Suit.Bells, Rank.Ten);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player0;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithAllCardsTheSame_ReturnsFirstPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Unter);
        List<Card> cardsInTrick = [
            card0,
            card0,
            card0,
            card0,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player1;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithMoreCardsThenPlayersAndFirstCardIsHightest_ReturnsFirstPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Unter);
        Card card1 = new(Suit.Leaves, Rank.Ober);
        Card card2 = new(Suit.Leaves, Rank.Seven);
        Card card3 = new(Suit.Bells, Rank.Ten);
        Card card4 = new(Suit.Hearts, Rank.Ace);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
            card4,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player1;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithMoreCardsThenPlayersAndSecondCardIsHightest_ReturnsSecondPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Leaves, Rank.Unter);
        Card card1 = new(Suit.Leaves, Rank.Ober);
        Card card2 = new(Suit.Leaves, Rank.Seven);
        Card card3 = new(Suit.Bells, Rank.Ten);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player2;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithLessCardsThenPlayersAndFirstCardIsHightest_ReturnsFirstPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Bells, Rank.Unter);
        Card card1 = new(Suit.Leaves, Rank.Ober);
        Card card2 = new(Suit.Leaves, Rank.Seven);
        Card card3 = new(Suit.Bells, Rank.Ten);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player1;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithLessCardsThenPlayersAndSecondCardIsHightest_ReturnsSecondPlayer()
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

        IPlayer firstPlayer = player1;

        Card card0 = new(Suit.Leaves, Rank.Unter);
        Card card1 = new(Suit.Leaves, Rank.Ober);
        Card card2 = new(Suit.Leaves, Rank.Seven);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player2;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithEmptyPlayers_ThrowsArgumentException()
    {
        // arrange
        List<IPlayer> players = [];

        IPlayer firstPlayer = new FakePlayer();

        Card card0 = new(Suit.Leaves, Rank.Unter);
        Card card1 = new(Suit.Leaves, Rank.Ober);
        Card card2 = new(Suit.Leaves, Rank.Seven);
        Card card3 = new(Suit.Acorns, Rank.Seven);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3
        ];

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick));

        Assert.That(thrownException.Message, Is.EqualTo("Argument \"Scheberln.Tests.Fakes.FakePlayer firstPlayer\" in GameHelpers.DeterminePlayerWithTrick is not contained in \"System.Collections.Generic.List`1[Scheberln.Players.IPlayer] players\"."));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithEmptyCards_ThrowsArgumentException()
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

        IPlayer firstPlayer = player1;

        List<Card> cardsInTrick = [];

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick));

        Assert.That(thrownException.Message, Is.EqualTo("Argument \"System.Collections.Generic.List`1[Scheberln.Cards.Card] cardsInTrick\" in GameHelpers.DeterminePlayerWithTrick must have at least one card."));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithFirstPlayerNotInPlayers_ThrowsArgumentException()
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

        IPlayer firstPlayer = new FakePlayer();

        Card card0 = new(Suit.Bells, Rank.Seven);
        Card card1 = new(Suit.Leaves, Rank.Ober);
        Card card2 = new(Suit.Leaves, Rank.Seven);
        Card card3 = new(Suit.Bells, Rank.Ten);
        List<Card> cardsInTrick = [
            card0,
            card1,
            card2,
            card3,
        ];

        // act/assert
        ArgumentException thrownException = Assert.Throws<ArgumentException>(() => GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick));

        Assert.That(thrownException.Message, Is.EqualTo("Argument \"Scheberln.Tests.Fakes.FakePlayer firstPlayer\" in GameHelpers.DeterminePlayerWithTrick is not contained in \"System.Collections.Generic.List`1[Scheberln.Players.IPlayer] players\"."));
    }
    
    [Test]
    public void TestDeterminePlayerWithTrick_WhenCalledWithOnlyOnePlayerInPlayers_ReturnsThisPlayer()
    {
        // arrange
        IPlayer player0 = new FakePlayer();
        List<IPlayer> players = [
            player0,
        ];

        IPlayer firstPlayer = player0;

        Card card0 = new(Suit.Bells, Rank.Seven);
        Card card1 = new(Suit.Bells, Rank.Ober);
        List<Card> cardsInTrick = [
            card0,
            card1,
        ];

        // act
        IPlayer playerWithTrick = GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);

        // assert
        IPlayer expectedPlayerWithTrick = player0;
        Assert.That(playerWithTrick, Is.SameAs(expectedPlayerWithTrick));
    }

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
