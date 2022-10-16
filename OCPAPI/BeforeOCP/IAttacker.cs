using System.Numerics;

namespace OCPAPI.BeforeOCP;

public interface IAttacker : IAttackable
{
    AttackResult Attack(IAttackable target);
}
public interface IAttackable
{
    string Name { get; }
    Vector2 Position { get; set; }
}
