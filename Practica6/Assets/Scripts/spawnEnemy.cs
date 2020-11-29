using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    private float timeSpawn = 6.0f;
    public Transform spawnPoints;
    private int maxEnemies = 5;
    //public int countEnemies = 0;
    private controller num;
    private Vector3[] points = { new Vector3(35,0.13f,0), new Vector3(-35, 0.13f, 0), new Vector3(0, 0.13f, 35), new Vector3(0, 0.13f, -35) };
    // Start is called before the first frame update
    void Start()
    {
        num = FindObjectOfType<controller>();
        InvokeRepeating("Spawn",timeSpawn,timeSpawn);
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void Spawn()
    {
        if(maxEnemies >= num.countEnemies)
        {
            spawnPoints.position = points[Random.Range(0,3)];
            //spawnPoints.position = new Vector3(Random.Range(-23, 23), 0.13f, Random.Range(-23, 23));
            Instantiate(enemy, spawnPoints.position, spawnPoints.rotation);
            num.countEnemies++;
        }
        
    }

}
