using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float   moveSpeed = 3.0f;
    private Vector3 moveDirection;
    private void Awake()
    {
        moveSpeed       = 5.0f;
        moveDirection   = Vector3.right;
    }
    private void Update()
    {
        /*
        moveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += Vector3.down;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += Vector3.right;
        }
        */

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(x, y, 0);

        // transform.position = transform.position + new Vector3(1, 0 ,0) * 1;
        // transform.position += new Vector3(1, 0, 0) * 1;
        // transform.position += Vector3.right * 1 * Time.deltaTime;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
