using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[]    arrayPrefabs;

    [SerializeField]
    private int             objectSpawnCount = 30;

    [SerializeField]
    private Transform[]     arraySpawnPoints;

    private int             currentObjectCount = 0;
    private float           currentSpawnTime = 0;

    private void Update()
    {
        if (currentObjectCount + 1 > objectSpawnCount)
        {
            return;
        }
        
        currentSpawnTime += Time.deltaTime;

        if (currentSpawnTime >= 0.5f)
        {
            int prefabIndex = Random.Range(0, arrayPrefabs.Length);
            int spawnIndex = Random.Range(0, arraySpawnPoints.Length);

            GameObject clone = Instantiate(arrayPrefabs[prefabIndex], arraySpawnPoints[spawnIndex].position, Quaternion.identity);

            Vector3 direction = spawnIndex == 0 ? Vector3.left : Vector3.right;
            clone.GetComponent<Movement2D_003>().MoveTo(direction);

            currentObjectCount ++;
            currentSpawnTime = 0;
        }
    }
}