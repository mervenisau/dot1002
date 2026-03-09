public class HealthPotion
{
    public int healAmount = 10;

    public void Consume(Player player)
    {
        player.Heal(healAmount);
    }
}