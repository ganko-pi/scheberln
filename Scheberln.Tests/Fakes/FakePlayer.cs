using Scheberln.Cards;
using Scheberln.Players;

namespace Scheberln.Tests.Fakes;

public class FakePlayer : IPlayer
{
    public List<Card> Cards { get; set; } = [];
}
