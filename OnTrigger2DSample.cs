using UnityEngine;

public class OnTrigger2DSample : MonoBehaviour
{
    [SerializeField]
    private Transform   moveobject;

    [SerializeField]
    private Vector3     movedirection;

    [SerializeField]
    private float       movespeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        moveobject.GetComponent<SpriteRenderer>().color = Color.black;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        moveobject.position += movedirection * movespeed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        moveobject.GetComponent<SpriteRenderer>().color = Color.white;
        moveobject.position = new Vector3(0, 2.5f, 0);
    }

}