using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeZ = 12.0f;
    private float spawnPosX = -20.0f;
    private int spawnDelay = 6;
    private float spawnInterval = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Randomly spawns an animal every few seconds
        InvokeRepeating("SpawnRandomAnimals", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        // Randomizes animals that spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Randomizes the animals spawn positions
        Vector3 spawnPos2 = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        // Instantiate animal objects
        Instantiate(animalPrefabs[animalIndex], spawnPos2,
                animalPrefabs[animalIndex].transform.rotation);
    }
}
