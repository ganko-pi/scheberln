using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint that a <see cref="IPlayer"/>
/// has no <see cref="Card"/>s with <see cref="Rank"/> <see cref="Rank.Unter"/>.
/// </summary>
public class HasNoUnterConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if (currentPlayer.Cards.Any(card => card.Rank == Rank.Unter))
        {
            return false;
        }

        return true;
    }
}
