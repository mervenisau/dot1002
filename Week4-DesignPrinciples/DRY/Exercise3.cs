void ApplyDamage(int damageAmount)
{
    health -= damageAmount;

    if (health < 0)
    {
        health = 0;
    }

    Debug.Log("Health: " + health);
}

void TakePhysicalDamage(int amount)
{
    ApplyDamage(amount);
}

void TakeMagicDamage(int amount)
{
    ApplyDamage(amount);
}