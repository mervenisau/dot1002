public class CollectibleDot
{
    public int pointValue = 10;

    public void Collect(Player player)
    {
        player.AddScore(pointValue);
    }
}