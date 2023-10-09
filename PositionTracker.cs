using UnityEngine;

public class PositionTracker : MonoBehaviour
{
    private Vector2 min = new Vector2(-9.5f, -5.5f);
    private Vector2 max = new Vector2(9.5f, 5.5f);

    private void Update()
    {
        if (transform.position.x < min.x || transform.position.x > max.x ||
            transform.position.y < min.y || transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
    }
}