using System.Collections.Generic;

using Scheberln.Cards;
using Scheberln.Game;

namespace Scheberln.Players;

/// <summary>
/// An interface representing a player.
/// </summary>
public interface IPlayer
{
    /// <summary>
    /// The cards the player currently holds.
    /// </summary>
    List<Card> Cards { get; set; }

    /// <summary>
    /// Returns a card the player wants to play based on the current state of the game.
    /// </summary>
    /// <param name="gameState">The current state of the game such as all played cards and the dealer.</param>
    /// <returns>A card the player wants to play.</returns>
    Card Play(GameState gameState);

    /// <summary>
    /// Informs the <see cref="IPlayer"/> that the played <paramref name="card"/> was accepted.
    /// </summary>
    /// <param name="card">The card the player played.</param>
    void CardPlayed(Card card);
}
