using Scheberln.Cards;
using Scheberln.Players;

namespace Scheberln.Game;

/// <summary>
/// An interface representing a game of Scheberln.
/// </summary>
public interface IGame
{
    /// <summary>
    /// Performs all actions to play a round in the game.
    /// </summary>
    /// <param name="gameState">The current state of the game.</param>
    /// <param name="firstDealer">The <see cref="IPlayer"/> who deals the cards first.</param>
    void PlayRound(GameState gameState, IPlayer firstDealer);

    /// <summary>
    /// Checks if <paramref name="cardThePlayerWantsToPlay"/> is a valid play by <paramref name="currentPlayer"/> for the current <paramref name="gameState"/>.
    /// </summary>
    /// <param name="gameState">The current state of the game.</param>
    /// <param name="currentPlayer">The player who wants to play <paramref name="cardThePlayerWantsToPlay"/>.</param>
    /// <param name="cardThePlayerWantsToPlay">The <see cref="Card"/> the <paramref name="currentPlayer"/> wants to play.</param>
    /// <returns><see langword="true"/> if the play is valid. <see langword="false"/> otherwise.</returns>
    bool IsValidPlay(GameState gameState, IPlayer currentPlayer, Card cardThePlayerWantsToPlay);
}
