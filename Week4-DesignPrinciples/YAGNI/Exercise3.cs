public class Spaceship : MonoBehaviour
{
    public float moveSpeed = 5f;

    public void MoveHorizontal(float input)
    {
        transform.Translate(Vector3.right * input * moveSpeed * Time.deltaTime);
    }
}