using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject[] animalsPrefabsArray;
    private int animalIndex;

    private float spawnRangeX = 15f;
    private float SpawnPosZ = 20f;

    [SerializeField] private float StartDelay = 2f;
    [SerializeField] private float SpawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomAnimal", StartDelay, SpawnInterval);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalsPrefabsArray.Length);
        Instantiate(animalsPrefabsArray[animalIndex],
            RandomSpawnPos(),
            Quaternion.Euler(0, 180, 0));
    }

    private Vector3 RandomSpawnPos()
    {
        float randomx = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomx, 0, SpawnPosZ);

    }
}
