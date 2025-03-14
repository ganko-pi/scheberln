using System;
using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Players;

namespace Scheberln.Game;

/// <summary>
/// A class with common functions for this game.
/// </summary>
public class GameHelpers
{
    /// <summary>
    /// An instance of this class.
    /// </summary>
    public static GameHelpers Instance { get; set; } = new GameHelpers();

    /// <summary>
    /// Returns the <see cref="IPlayer"/> from <paramref name="players"/> who played the trick-taking <see cref="Card"/> in <paramref name="cardsInTrick"/>.
    /// </summary>
    /// <param name="players">The <see cref="IPlayer"/>s participating in the game.</param>
    /// <param name="firstPlayer">The <see cref="IPlayer"/> who played the first <see cref="Card"/> in <paramref name="cardsInTrick"/>.</param>
    /// <param name="cardsInTrick">All played <see cref="Card"/>s in the current trick.</param>
    /// <returns>The <see cref="IPlayer"/> from <paramref name="players"/> who played the trick-taking <see cref="Card"/> in <paramref name="cardsInTrick"/>.</returns>
    /// <exception cref="ArgumentException">
    /// Exception if <paramref name="cardsInTrick"/> is empty or <paramref name="firstPlayer"/> is not part of the <paramref name="players"/>.
    /// </exception>
    public IPlayer DeterminePlayerWithTrick(List<IPlayer> players, IPlayer firstPlayer, List<Card> cardsInTrick)
    {
        if (!cardsInTrick.Any())
        {
            throw new ArgumentException($"Argument \"{cardsInTrick.GetType()} {nameof(cardsInTrick)}\" in {nameof(GameHelpers)}.{nameof(DeterminePlayerWithTrick)} must have at least one card.");
        }

        int indexOfFirstPlayer = players.IndexOf(firstPlayer);
        if (indexOfFirstPlayer == -1)
        {
            throw new ArgumentException($"Argument \"{firstPlayer.GetType()} {nameof(firstPlayer)}\" in {nameof(GameHelpers)}.{nameof(DeterminePlayerWithTrick)} is not contained in \"{players.GetType()} {nameof(players)}\".");
        }

        int offsetOfPlayerWithTrick = 0;

        Suit suitInThisTrick = cardsInTrick[0].Suit;
        Rank currentHighestRank = cardsInTrick[0].Rank;
        for (int i = 1; i < cardsInTrick.Count; ++i)
        {
            if (cardsInTrick[i].Suit != suitInThisTrick)
            {
                continue;
            }

            if (cardsInTrick[i].Rank <= currentHighestRank)
            {
                continue;
            }

            offsetOfPlayerWithTrick = i;
            currentHighestRank = cardsInTrick[i].Rank;
        }

        int indexOfPlayerWithTrick = (indexOfFirstPlayer + offsetOfPlayerWithTrick) % players.Count;

        return players[indexOfPlayerWithTrick];
    }

    /// <summary>
    /// Returns the <see cref="IPlayer"/> who is next in <paramref name="players"/> after <paramref name="currentPlayer"/>.
    /// </summary>
    /// <param name="players">The <see cref="IPlayer"/>s participating in the game.</param>
    /// <param name="currentPlayer">The <see cref="IPlayer"/> before the <see cref="IPlayer"/> to find.</param>
    /// <returns>The <see cref="IPlayer"/> who is next in <paramref name="players"/> after <paramref name="currentPlayer"/>.</returns>
    /// <exception cref="ArgumentException">Exception if<paramref name="currentPlayer"/> is not part of the <paramref name="players"/>.</exception>
    public IPlayer GetNextPlayer(List<IPlayer> players, IPlayer currentPlayer)
    {
        if (!players.Contains(currentPlayer))
        {
            throw new ArgumentException($"{currentPlayer.GetType()} {currentPlayer} in {nameof(GameHelpers)}.{nameof(GetNextPlayer)} is not part of {nameof(players)}.");
        }
        
        int indexOfCurrentPlayer = players.IndexOf(currentPlayer);
        int indexOfNextPlayer = (indexOfCurrentPlayer + 1) % players.Count;
        return players[indexOfNextPlayer];
    }

    /// <summary>
    /// Returns the <see cref="Objective"/> which is next after <paramref name="currentObjective"/>.
    /// </summary>
    /// <param name="currentObjective">The <see cref="Objective"/> before the <see cref="Objective"/> to find.</param>
    /// <returns>The <see cref="Objective"/> which is next after <paramref name="currentObjective"/>.</returns>
    public Objective GetNextObjective(Objective currentObjective)
    {
        Objective[] objectiveValues = Enum.GetValues<Objective>();
        int indexOfCurrentObjective = Array.IndexOf(objectiveValues, currentObjective);
        int indexOfNextObjective = (indexOfCurrentObjective + 1) % objectiveValues.Length;
        return objectiveValues[indexOfNextObjective];
    }
}
