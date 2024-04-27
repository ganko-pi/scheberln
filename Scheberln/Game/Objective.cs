namespace Scheberln.Game;

/// <summary>
/// An enum representing the possible objectives of a deal.
/// </summary>
public enum Objective
{
    /// <summary>
    /// Objective to take no tricks.
    /// </summary>
    NoTricks,
    /// <summary>
    /// Objective to have no cards of suit Hearts in the tricks taken.
    /// </summary>
    NoHearts,
    /// <summary>
    /// Objective to have no cards of rank Ober in the tricks taken.
    /// </summary>
    NoObers,
    /// <summary>
    /// Objective to not have the king of Hearts in a trick taken
    /// </summary>
    NoHeartsKing,
    /// <summary>
    /// Objective to lay down the cards in as few plays as possible.
    /// </summary>
    Domino,
}
