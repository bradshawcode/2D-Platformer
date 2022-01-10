using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    UIManager Instance { get { return instance; } }

    [Header("UI Menus")] [SerializeField] private GameObject gameHUD;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        instance = GameObject.FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        UpdateHUD();
    }

    private void UpdateHUD()
    {
        if (scoreText)
            scoreText.text = GameManager.EnemySpawner.Score.ToString();
        if (healthText)
            healthText.text = GameManager.MainPlayer.Health.ToString();
    }
}
