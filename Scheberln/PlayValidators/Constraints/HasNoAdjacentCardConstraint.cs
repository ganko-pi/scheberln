using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint that a <see cref="IPlayer"/>
/// has no adjancent <see cref="Card"/>s of the currently played cards.
/// </summary>
public class HasNoAdjacentCardConstraint : IConstraint
{
    private readonly MustPlayAdjacentCardConstraint _mustPlayAdjacentCardConstraint = new();

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if (currentPlayer.Cards.Any(card => _mustPlayAdjacentCardConstraint.IsFullfilled(gameState, currentPlayer, card)))
        {
            return false;
        }

        return true;
    }
}
