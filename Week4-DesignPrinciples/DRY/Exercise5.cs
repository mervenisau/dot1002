public float horizontalLimit = 100f;

void MoveHorizontal(float direction)
{
    float nextPositionX = transform.position.x + direction * speed * Time.deltaTime;

    if (nextPositionX >= -horizontalLimit && nextPositionX <= horizontalLimit)
    {
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }
}

void MoveRight()
{
    MoveHorizontal(1f);
}

void MoveLeft()
{
    MoveHorizontal(-1f);
}