float cooldownRemaining = 5f;

void Update()
{
    if (cooldownRemaining > 0f)
    {
        cooldownRemaining -= Time.deltaTime;
    }
}