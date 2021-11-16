using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    //posicion de spawneo
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;
    
    // Start is called once in the beggining
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, 5f);
    }

    //rango aleatorio que puede spawnear el obstaculo
    void SpawnObstacle()
    {
        randomY = Random.Range(-10, 10);
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);
        //Spawneo de los obstaculos
        Instantiate(ObstaclePrefab, spawnPos, ObstaclePrefab.transform.rotation);
    }
}
