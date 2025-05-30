using System.Collections.Generic;
using System.Linq;

using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;
using Scheberln.Score;

namespace Scheberln;

internal class Program
{
    private static void Main()
    {
        // using GraphicalGame game = new();
        // game.Run();

        List<IPlayer> players = new()
        {
            new ConsolePlayer(),
            new ConsolePlayer(),
            new ConsolePlayer(),
            new ConsolePlayer(),
        };
        Deck deck = new();
        GameState gameState = new(players, deck);

        Scoreboard scoreboard = new();

        ConsoleGame game = new(scoreboard);
        game.PlayRound(gameState, players.First());
    }
}
