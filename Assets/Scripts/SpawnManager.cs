using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRange = 30;
        

    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnEnemy", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        //float spawmPosZ = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = 100f;
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

}
