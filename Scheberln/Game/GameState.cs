using System.Collections.Generic;

using Scheberln.Cards;
using Scheberln.Players;

namespace Scheberln.Game;

/// <summary>
/// A record representing the current state of the game.
/// </summary>
/// <param name="Players">The players participating in the game.</param>
/// <param name="Deck">The card deck used in the game.</param>
public record GameState(List<IPlayer> Players, Deck Deck)
{
    /// <summary>
    /// The players participating in the game.
    /// </summary>
    public List<IPlayer> Players { get; } = Players;
    /// <summary>
    /// The card deck used in the game.
    /// </summary>
    public Deck Deck { get; } = Deck;
    
    /// <summary>
    /// The current objective of the deal.
    /// </summary>
    public Objective? CurrentObjective { get; set; }
    /// <summary>
    /// The player who dealt the cards in the current deal.
    /// </summary>
    public IPlayer? Dealer { get; set; }
    /// <summary>
    /// All played cards in the deal.
    /// </summary>
    public List<Card> AllPlayedCardsInDeal { get; set; } = new List<Card>();
}
