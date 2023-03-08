using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgressiveAnimal : MonoBehaviour
{
    public GameObject[] animalPrefabLeft;
    public GameObject[] animalPrefabRight;
    private float spawnRangeZmin = 2;
    private float spawnRangeZmax = 16;
    private float spawnPosX = 30;
    private float startDelay = 5;
    private float spawnInterval = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);

        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnHostileAnimalLeft()
    {
        //Randomly generates animalIndex and spawn position
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZmin, spawnRangeZmax));

        int animalIndexLeft = Random.Range(0, animalPrefabLeft.Length);

        Instantiate(animalPrefabLeft[animalIndexLeft], spawnPos, animalPrefabLeft[animalIndexLeft].transform.rotation);
    }

    void SpawnHostileAnimalRight()
    {
        //Randomly generates animalIndex and spawn position
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZmin, spawnRangeZmax));

        int animalIndexRight = Random.Range(0, animalPrefabRight.Length);

        Instantiate(animalPrefabRight[], spawnPos, animalPrefabRight[].transform.rotation);
    }
}
