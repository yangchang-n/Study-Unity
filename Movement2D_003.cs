using UnityEngine;

public class Movement2D_003 : MonoBehaviour
{
    private Vector3 moveDirection;
    private float   moveSpeed = 5.0f;

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3 direction)
    {
        moveDirection = direction;
    }
}