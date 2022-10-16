using System.Numerics;

namespace OCPAPI.BeforeOCP;

public class Sword : Weapon
{
    public override float MinRanged { get; } = 0;
    public override float MaxRanged { get; } = Vector2.Distance(Vector2.Zero, Vector2.One);
}