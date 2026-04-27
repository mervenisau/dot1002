using System;

public interface IAttackable
{
    void Attack();
}

public interface IReloadable
{
    void Reload();
}

public interface IAimable
{
    void AimDownSights();
}

public class SniperRifle : IAttackable, IReloadable, IAimable
{
    public void Attack()
    {
        Console.WriteLine("Firing a high-caliber round!");
    }

    public void Reload()
    {
        Console.WriteLine("Loading a new magazine.");
    }

    public void AimDownSights()
    {
        Console.WriteLine("Looking through the 8x scope.");
    }
}

public class Sword : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Swinging the sword!");
    }
}

public class Program
{
    public static void Main()
    {
        SniperRifle sniperRifle = new SniperRifle();
        Sword sword = new Sword();

        sniperRifle.Attack();
        sniperRifle.Reload();
        sniperRifle.AimDownSights();

        sword.Attack();
    }
}