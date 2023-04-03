using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    private static GameManager Instance;
    public PlayerHealth playerHealth;

    public int health;
    public int maxHealth;
    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;
    public int score;

    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        score = 0;
        updateScore(0);
    }

    void Update()
    {
        health = playerHealth.health;
        maxHealth = playerHealth.maxhealth;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }

    public void updateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score;
    }
}
