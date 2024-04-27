using Scheberln.Cards;
using Scheberln.Game;
using Scheberln.Players;

namespace Scheberln.Tests.Fakes;

public class FakePlayer : IPlayer
{
    public List<Card> Cards { get; set; } = [];

    public Card Play(GameState gameState)
    {
        return Cards.FirstOrDefault()!;
    }
}
