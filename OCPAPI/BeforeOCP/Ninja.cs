using System.Numerics;

namespace OCPAPI.BeforeOCP;

public class Ninja : IAttackable, IAttacker
{
    private readonly Weapon _meleeWeapon;
    private readonly Weapon _rangedWeapon;
    public string Name { get; }
    public Vector2 Position { get; set; }

    public Ninja(string name, Weapon meleeWeapon, Weapon rangedWeapon, Vector2? position = null)
    {
        Name = name;
        _meleeWeapon = meleeWeapon;
        _rangedWeapon = rangedWeapon;
        Position = position ?? Vector2.Zero;
    }

    public AttackResult Attack(IAttackable target)
    {
        var distance = this.DistanceFrom(target);
        return _meleeWeapon.CanHit(distance) ? 
            new AttackResult(_meleeWeapon, this, target) : 
            new AttackResult(_rangedWeapon, this, target);
    }
}