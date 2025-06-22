using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> to combine multiple other <see cref="IConstraint"/>s.
/// This constraint is fullfilled when at least one of the passed <see cref="IConstraint"/>s is fullfilled.
/// </summary>
public class OrConstraint : IConstraint
{
    private readonly IConstraint[] _constraints;

    /// <summary>
    /// Creates a new <see cref="OrConstraint"/> combining the passed <paramref name="constraints"/>.
    /// </summary>
    public OrConstraint(params IConstraint[] constraints)
    {
        _constraints = constraints;
    }

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        return _constraints.Any(constraint => constraint.IsFullfilled(gameState, currentPlayer, cardThePlayerWantsToPlay));
    }
}
