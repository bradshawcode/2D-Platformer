using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Spawner Settings")] [SerializeField] Transform[] spawnPoints;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnFrequency = 0;
    private float timer = 0;
    private int score = 0;
    public int Score { get { return score; } set { score = value; } }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnFrequency)
        {
            Spawn();
            timer = 0;
        }
             
    }

    private void Spawn()
    {
        foreach (Transform spawnPoint in spawnPoints)
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}
