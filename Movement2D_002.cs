using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;

    private float       movespeed = 3.0f;
    private Vector3     movedirection;

    private void Awake()
    {
        rigidbody2d     = GetComponent<Rigidbody2D>();

        movespeed       = 5.0f;
        movedirection   = Vector3.right;
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

        movedirection = new Vector3(x, y, 0);

        // transform.position = transform.position + new Vector3(1, 0 ,0) * 1;
        // transform.position += new Vector3(1, 0, 0) * 1;
        // transform.position += Vector3.right * 1 * Time.deltaTime;
        // transform.position += movedirection * movespeed * Time.deltaTime;
        rigidbody2d.velocity = movedirection * movespeed;
    }
}
