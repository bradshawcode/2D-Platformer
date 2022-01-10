using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("GameManager Settings")]
    private static GameManager instance;
    [SerializeField] private MainPlayer player;
    [SerializeField] private EnemySpawner enemy;
    private static MainPlayer mainPlayer = null;
    private static EnemySpawner enemySpawner = null;

    [Header("Map Settings")] [SerializeField] private Transform map;

    public static GameManager Instance { get { return instance; } }
    public static MainPlayer MainPlayer { get { return mainPlayer; } }
    public static EnemySpawner EnemySpawner { get { return enemySpawner; } }
    public Transform Map { get { return map; } }

    private void Awake()
    {
        instance = GameObject.FindObjectOfType<GameManager>();
        mainPlayer = player;
        enemySpawner = enemy;
    }

}
