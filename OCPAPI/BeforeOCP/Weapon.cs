namespace OCPAPI.BeforeOCP;

public abstract class Weapon
{
    public abstract float MinRanged { get; }
    public abstract float MaxRanged { get; }
    public virtual string Name => GetType().Name;
    public virtual bool CanHit(float distance)
        => distance >= MinRanged && distance <= MaxRanged;
}