using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  public GameObject enemyPrefab;

  public Transform[] spawnPoints;

  public float interval;
    void Start()
    {
        InvokeRepeating("SpawnStart",0.5f, interval);
    }

    // Update is called once per frame
   private void SpawnStart()
   {
    int ranPos = Random.Range(0, spawnPoints.Length);
    GameObject newEnemy = Instantiate(enemyPrefab, spawnPoints[ranPos].position,Quaternion.identity);
   }
}
