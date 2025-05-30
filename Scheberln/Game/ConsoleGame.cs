using System;
using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Players;
using Scheberln.Score;

namespace Scheberln.Game;

public class ConsoleGame : IGame
{
    private IScoreboard _scoreboard;

    public ConsoleGame(IScoreboard scoreboard)
    {
        _scoreboard = scoreboard;
    }

    public void PlayRound(GameState gameState, IPlayer firstDealer)
    {
        Deck deck = gameState.Deck;
        List<IPlayer> players = gameState.Players;
        gameState.CurrentObjective = Objective.NoTricks;
        gameState.Dealer = firstDealer;
        gameState.AllPlayedCardsInDeal.Clear();

        deck.DealAllCards(players);

        IPlayer currentPlayer = firstDealer;
        while (players.All(player => player.Cards.Any()))
        {
            currentPlayer = PlayTrickAndGetPlayerWithTrick(gameState, deck, players, currentPlayer);
        }

        _scoreboard.UpdatePointsAfterDeal(gameState);

        deck.AddCards(gameState.AllPlayedCardsInDeal);
        gameState.AllPlayedCardsInDeal.Clear();

        gameState.Dealer = GameHelpers.Instance.GetNextPlayer(gameState.Players, gameState.Dealer);

        gameState.CurrentObjective = GameHelpers.Instance.GetNextObjective((Objective)gameState.CurrentObjective);
    }

    private IPlayer PlayTrickAndGetPlayerWithTrick(GameState gameState, Deck deck, List<IPlayer> players, IPlayer currentPlayer)
    {
        IPlayer firstPlayer = currentPlayer;

        for (int i = 0; i < players.Count; ++i)
        {
            Card cardToPlay = PlayValidCard(currentPlayer, gameState);
            gameState.AllPlayedCardsInDeal.Add(cardToPlay);
            currentPlayer.CardPlayed(cardToPlay);

            currentPlayer = GameHelpers.Instance.GetNextPlayer(players, currentPlayer);
        }

        int playedCardsCount = players.Count;
        int startIndexForCardsInTrick = gameState.AllPlayedCardsInDeal.Count - playedCardsCount;
        List<Card> cardsInTrick = gameState.AllPlayedCardsInDeal.GetRange(startIndexForCardsInTrick, playedCardsCount);
        deck.AddCards(cardsInTrick);

        return GameHelpers.Instance.DeterminePlayerWithTrick(players, firstPlayer, cardsInTrick);
    }

    public bool IsValidPlay(GameState gameState, IPlayer currentPlayer, Card cardThePlayerWantsToPlay)
    {
        List<IPlayer> players = gameState.Players;
        if (!currentPlayer.Cards.Contains(cardThePlayerWantsToPlay))
        {
            return false;
        }

        Objective currentObjective = (Objective)gameState.CurrentObjective;
        if (currentObjective == Objective.Domino)
        {
            return IsValidPlayForDomino(gameState, cardThePlayerWantsToPlay);
        }

        List<Card> allPlayedCardsInDeal = gameState.AllPlayedCardsInDeal;
        int firstCardIndex = allPlayedCardsInDeal.Count / players.Count * players.Count;
        
        if (firstCardIndex >= allPlayedCardsInDeal.Count)
        {
            return true;
        }

        Card firstCard = allPlayedCardsInDeal[firstCardIndex];

        if (cardThePlayerWantsToPlay.Suit == firstCard.Suit)
        {
            return true;
        }

        if (!currentPlayer.Cards.Any(card => card.Suit == firstCard.Suit))
        {
            return true;
        }

        return false;
    }

    private bool IsValidPlayForDomino(GameState gameState, Card cardThePlayerWantsToPlay)
    {
        throw new NotImplementedException();
    }

    private Card PlayValidCard(IPlayer player, GameState gameState)
    {
        Card cardThePlayerWantsToPlay;
        do
        {
            cardThePlayerWantsToPlay = player.Play(gameState);
        }
        while (!IsValidPlay(gameState, player, cardThePlayerWantsToPlay));

        return cardThePlayerWantsToPlay;
    }
}
