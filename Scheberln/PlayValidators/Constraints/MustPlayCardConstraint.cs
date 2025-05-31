using System;
using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.PlayValidators.Constraints;

/// <summary>
/// Implementation of <see cref="IConstraint"/> representing the constraint a <see cref="Card"/> must be played.
/// </summary>
public class MustPlayCardConstraint : IConstraint
{

    /// <inheritdoc/>
    public bool IsFullfilled(GameState gameState, IPlayer currentPlayer, Card? cardThePlayerWantsToPlay)
    {
        bool cardThePlayerWantsToPlayIsNotNull = cardThePlayerWantsToPlay != null; 
        return cardThePlayerWantsToPlayIsNotNull;
    }
}
