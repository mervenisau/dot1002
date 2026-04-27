using System;

public class EnemyNPC
{
    public string Name { get; set; }
    public int AttackPower { get; set; }

    public EnemyNPC(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }
}

public class EnemyMovementAI
{
    public void ChasePlayer(EnemyNPC enemy)
    {
        Console.WriteLine($"{enemy.Name} is chasing the player.");
    }
}

public class EnemyLootDropper
{
    public void DropLoot(EnemyNPC enemy)
    {
        Console.WriteLine($"{enemy.Name} dropped gold and items.");
    }
}

public class EnemyHealthBarRenderer
{
    public void RenderHealthBar(EnemyNPC enemy)
    {
        Console.WriteLine($"Rendering health bar for {enemy.Name}.");
    }
}

public class Program
{
    public static void Main()
    {
        EnemyNPC enemy = new EnemyNPC("Goblin", 15);

        EnemyMovementAI enemyMovementAI = new EnemyMovementAI();
        EnemyLootDropper enemyLootDropper = new EnemyLootDropper();
        EnemyHealthBarRenderer enemyHealthBarRenderer = new EnemyHealthBarRenderer();

        enemyMovementAI.ChasePlayer(enemy);
        enemyLootDropper.DropLoot(enemy);
        enemyHealthBarRenderer.RenderHealthBar(enemy);
    }
}