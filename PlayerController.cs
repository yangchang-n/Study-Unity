using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject  projectilePrefab;
    private float       moveSpeed = 5.0f;

    private Vector3     lastMoveDirection = Vector3.right;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;

        if (x != 0 || y != 0)
        {
            lastMoveDirection = new Vector3(x, y, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            clone.name = "Projectile";
            clone.transform.localScale = Vector3.one * 0.5f;
            clone.GetComponent<SpriteRenderer>().color = Color.red;

            clone.GetComponent<Movement2D_003>().MoveTo(lastMoveDirection);
        }
    }
}