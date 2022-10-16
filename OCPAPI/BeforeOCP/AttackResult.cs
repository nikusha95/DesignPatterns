using System.Numerics;

namespace OCPAPI.BeforeOCP;

public class AttackResult
{
    public string Weapon { get; set; }
    public string Attacker { get; set; }
    public string Target { get; set; }
    public bool Succeeded { get; set; }
    public float Distance { get; set; }

    public AttackResult(Weapon weapon, IAttacker attacker, IAttackable target)
    {
        Weapon = $"{weapon.Name} (Min: {weapon.MinRanged}, Max: {weapon.MaxRanged})";
        Attacker = $"{attacker.Name} (Position: {attacker.Position})";
        Target = $"{target.Name} (Position: {target.Position})";
        Distance = attacker.DistanceFrom(target);
        Succeeded = weapon.CanHit(Distance);
    }
    
}

public static class AttackableExtension
{
    public static float DistanceFrom(this IAttackable attacker, IAttackable target)
    {
        return Vector2.Distance(attacker.Position, target.Position);
    }

    public static IAttackable MoveTo(this IAttackable target, float x, float y)
    {
        target.Position = new Vector2(x, y);
        return target;
    }
}