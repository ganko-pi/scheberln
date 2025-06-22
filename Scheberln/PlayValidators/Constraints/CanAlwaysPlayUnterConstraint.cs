using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint that a <see cref="Card"/>
/// with <see cref="Rank"/> <see cref="Rank.Unter"/> can always be played.
/// </summary>
public class CanAlwaysPlayUnterConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        if (cardThePlayerWantsToPlay?.Rank == Rank.Unter)
        {
            return true;
        }

        return false;
    }
}
