namespace OCP;

public interface IAttacker : IAttackable
{
    AttackResult Attack(IAttackable target);
}
public interface IAttackable
{
    string Name { get; }
    Vector2 Position { get; set; }
}

public class Vector2
{
    public const int Zero = 0;
    public const int One = 1;
}