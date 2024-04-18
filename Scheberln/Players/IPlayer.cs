using System.Collections.Generic;

using Scheberln.Cards;

namespace Scheberln.Players;

/// <summary>
/// An interface representing a player.
/// </summary>
public interface IPlayer
{
    /// <summary>
    /// The cards the player currently holds.
    /// </summary>
    public List<Card> Cards { get; set; }
}
