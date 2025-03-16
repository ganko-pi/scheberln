using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> to combine multiple other <see cref="IConstraint"/>s.
/// This constraint is fulfilled when all passed <see cref="IConstraint"/>s are fulfilled.
/// </summary>
public class AndConstraint : IConstraint
{
    private readonly IConstraint[] _constraints;

    /// <summary>
    /// Creates a new <see cref="AndConstraint"/> combining the passed <paramref name="constraints"/>.
    /// </summary>
    public AndConstraint(params IConstraint[] constraints)
    {
        _constraints = constraints;
    }

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        return _constraints.All(constraint => constraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay));
    }
}
