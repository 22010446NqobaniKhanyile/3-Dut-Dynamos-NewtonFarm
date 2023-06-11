using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs : MonoBehaviour
{
    public GameObject bombs;

    public Transform[] spawnPoints;

    public float timeBetweenSpawns;
    public float nextSpawnTime;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,10),5,0);
            Instantiate(bombs, randomSpawnPosition, Quaternion.identity);
        

            nextSpawnTime = Time.time + timeBetweenSpawns;
           
        }
    }

   
}
