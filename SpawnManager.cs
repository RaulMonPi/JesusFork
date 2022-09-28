using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerCScript.gameOver == false)
        {
            randomObstacle = Random.Range(0, obstaclePrefab.Length);
            Instantiate(obstaclePrefab[randomObstacle], spawnPos, obstaclePrefab[randomObstacle].transform.rotation);
        }
    }
}
