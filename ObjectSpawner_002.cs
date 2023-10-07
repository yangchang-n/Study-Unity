using UnityEngine;

public class ObjectSpawner_002 : MonoBehaviour
{
    [SerializeField]
    // private GameObject      squarePrefab;
    private GameObject[]    arrayPrefabs;

    [SerializeField]
    private int             objectSpawnCount = 30;

    [SerializeField]
    private Transform[]     arraySpawnPoints;

//    private int             currentObjectCount = 0;
//    private float           currentSpawnTime = 0;

    private void Awake()
    {
        /*
        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        GameObject clone = Instantiate(squarePrefab, new Vector3(2, 2, 0), rotation);
        
        clone.name = "Square001";
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        clone.transform.position = Vector3.zero;
        */

        /*
        for (int y = 0; y < 10; ++ y)
        {
            for (int x = 0; x < 10; ++ x)
            {
                if (x + y == 4 || x - y == 5 || y - x == 5 || x + y == 14)
                {
                    continue;
                }
                Vector3 position = new Vector3(-4.5f + x, 4.5f - y, 0);

                GameObject clone = Instantiate(squarePrefab, position, Quaternion.identity);

                clone.transform.localScale = Vector3.one * 0.95f;
            }
        }
        */

        for (int i = 0; i < objectSpawnCount; ++ i)
        {
            int prefabIndex = Random.Range(0, arrayPrefabs.Length);

            // Vector3 position = new Vector3(-4.5f + i, 0, 0);
            // Vector3 position = new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(-4.5f, 4.5f), 0);
            int spawnIndex = Random.Range(0, arraySpawnPoints.Length);

            // Instantiate(arrayPrefabs[prefabIndex], position, Quaternion.identity);
            // Instantiate(arrayPrefabs[prefabIndex], arraySpawnPoints[spawnIndex].position, Quaternion.identity);
            GameObject clone = Instantiate(arrayPrefabs[prefabIndex], arraySpawnPoints[spawnIndex].position, Quaternion.identity);

            Vector3 direction = spawnIndex == 0 ? Vector3.left : Vector3.right;
            clone.GetComponent<Movement2D_003>().MoveTo(direction);
        }
    }

    /*
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
    */
}