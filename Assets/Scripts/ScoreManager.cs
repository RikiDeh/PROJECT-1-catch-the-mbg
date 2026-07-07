using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    private int timeLeft = 60;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Score     : " + score.ToString();
        timeText.text = "Time Left  : " + timeLeft.ToString();
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score     : " + score.ToString();
    }
}
