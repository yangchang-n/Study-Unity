using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject  squarePrefab;

    private void Awake()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        GameObject clone = Instantiate(squarePrefab, new Vector3(2, 2, 0), rotation);
        
        clone.name = "Square001";
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        clone.transform.position = Vector3.zero;
    }
}