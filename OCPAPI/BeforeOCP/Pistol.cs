using System.Numerics;

namespace OCPAPI.BeforeOCP;

public class Pistol : Weapon
{
    public override float MinRanged { get; } = Vector2.Distance(Vector2.Zero, Vector2.One);
    public override float MaxRanged { get; } = 50;
}