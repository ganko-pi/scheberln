using System;
using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;

namespace Scheberln.Players;

/// <summary>
/// Implementation of <see cref="IPlayer"/> utilizing the user input from the console.
/// </summary>
public class ConsolePlayer : IPlayer
{
    /// <inheritdoc/>
    public List<Card> Cards { get; set; } = new();

    /// <inheritdoc/>
    public Card Play(GameState gameState)
    {
        Console.WriteLine();
        Console.WriteLine("---------------");

        int finishedTricks = gameState.AllPlayedCardsInDeal.Count / gameState.Players.Count;
        int indexOfFirstCardInCurrentTrick = finishedTricks * gameState.Players.Count;
        List<Card> cardsInCurrentTrick = gameState.AllPlayedCardsInDeal.Skip(indexOfFirstCardInCurrentTrick).ToList();

        Console.WriteLine("Current trick:");
        PrintListWithIndexToConsole(cardsInCurrentTrick);
        Console.WriteLine();

        Console.WriteLine("Own cards:");
        PrintListWithIndexToConsole(Cards);
        Console.WriteLine();

        return SelectCard();
    }

    private void PrintListWithIndexToConsole<T>(List<T> list)
    {
        list
            .Select((listItem, index) => $"{index}: {listItem}")
            .ToList()
            .ForEach(listItemString => Console.WriteLine(listItemString));
    }

    private Card SelectCard()
    {
        string? input;
        int cardIndex;
        do
        {
            Console.WriteLine("Please select the index of the card to play:");
            input = Console.ReadLine();
        }
        while (!int.TryParse(input, out cardIndex)
            && cardIndex >= 0
            && cardIndex < Cards.Count);

        return Cards[cardIndex];
    }

    public void CardPlayed(Card card)
    {
        Cards.Remove(card);
    }
}
