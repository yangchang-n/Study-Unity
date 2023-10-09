using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject  playerObject;
    
    private void Awake()
    {   
        // GetComponent<PlayerController>.enabled = false;
        // Destroy(playerObject.GetComponent<PlayerController>());
        // Destroy(playerObject, 2.0f);
    }
}