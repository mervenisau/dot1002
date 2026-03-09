void SpawnEnemy(GameObject enemyPrefab)
{
    Vector3 spawnPosition = transform.position + new Vector3(0, 1, 0);
    Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    PlaySpawnParticle(spawnPosition);
}

void SpawnGoblin()
{
    SpawnEnemy(goblinPrefab);
}

void SpawnOrc()
{
    SpawnEnemy(orcPrefab);
}