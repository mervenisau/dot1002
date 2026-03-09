void CheckEnemy(string enemyType)
{
    if (enemyType == "Goblin" || enemyType == "Orc" || enemyType == "Troll")
    {
        Attack();
    }
    else
    {
        RunAway();
    }
}