using UnityEngine;

public class RandomFallingObject : MonoBehaviour
{
    // The prefab of the object that will fall
    public GameObject fallingObjectPrefab;

    // The spawn interval range, in seconds
    public float minSpawnInterval = 2f;
    public float maxSpawnInterval = 5f;

    // The spawn height, in world units
    public float spawnHeight = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to the FallingObject prefab
        fallingObjectPrefab = Resources.Load<GameObject>("FallingObject");

        // Start the spawning process
        SpawnFallingObject();
    }

    // Spawn a new falling object
    void SpawnFallingObject()
    {
        // Instantiate the FallingObject prefab at a random position
        GameObject fallingObject = Instantiate(fallingObjectPrefab, new Vector3(Random.Range(-2.5f, 2.5f), spawnHeight, 0f), Quaternion.identity);

        // Schedule the next spawn after a random delay between minSpawnInterval and maxSpawnInterval
        float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnFallingObject", spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the falling object down at a constant speed
        transform.Translate(Vector3.down * Time.deltaTime * 5f, Space.World);

        // Check if the falling object has fallen past the bottom of the screen
        if (transform.position.y < -5f)
        {
            // Reposition the object to a random position at the top of the screen
            transform.position = new Vector3(Random.Range(-2.5f, 2.5f), spawnHeight, 0f);
        }
    }
}
