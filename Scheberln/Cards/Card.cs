namespace Scheberln.Cards;

/// <summary>
/// An enum representing the different available suits a card can have.
/// </summary>
public enum Suit
{
    /// <summary>
    /// The card suit Bells.
    /// </summary>
    Bells,
    /// <summary>
    /// The card suit Hearts.
    /// </summary>
    Hearts,
    /// <summary>
    /// The card suit Leaves.
    /// </summary>
    Leaves,
    /// <summary>
    /// The card suit Acorns.
    /// </summary>
    Acorns,
}

/// <summary>
/// An enum representing the different available ranks a card can have.
/// </summary>
public enum Rank
{
    /// <summary>
    /// The card rank Seven.
    /// </summary>
    Seven = 7,
    /// <summary>
    /// The card rank Eight.
    /// </summary>
    Eight,
    /// <summary>
    /// The card rank Nine.
    /// </summary>
    Nine,
    /// <summary>
    /// The card rank Ten.
    /// </summary>
    Ten,
    /// <summary>
    /// The card rank Unter.
    /// </summary>
    Unter,
    /// <summary>
    /// The card rank Ober.
    /// </summary>
    Ober,
    /// <summary>
    /// The card rank King.
    /// </summary>
    King,
    /// <summary>
    /// The card rank Ace.
    /// </summary>
    Ace
}

/// <summary>
/// A record representing a playing card.
/// </summary>
/// <param name="Suit">The suit of the card.</param>
/// <param name="Rank">The rank of the card.</param>
public record Card(Suit Suit, Rank Rank);
