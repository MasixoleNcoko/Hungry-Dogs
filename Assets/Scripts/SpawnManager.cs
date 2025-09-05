using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private int spawnDelay = 5;
    private float spawnInterval = 2.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Randomly spawns an animal every few seconds
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        // Randomizes animals that spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Randomizes the animals spawn positions
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        // Instantiates animal objects
        Instantiate(animalPrefabs[animalIndex], spawnPos,
                animalPrefabs[animalIndex].transform.rotation);
        
    }

}
