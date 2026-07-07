using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    private int timeLeft = 60;
    private int score = 0;

    [Header("Game Over UI Setup")]
    public GameObject panelGameOver; 
    public TextMeshProUGUI totalScoreText;
    private bool gameHasEnded = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this; 
            Time.timeScale = 1f; 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        scoreText.text = "Score     : " + score.ToString();
        timeText.text = "Time Left  : " + timeLeft.ToString();

        StartCoroutine(CountdownWaktu());
    }
    IEnumerator CountdownWaktu()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1f);
            timeLeft--;
            timeText.text = "Time Left  : " + timeLeft.ToString(); 
        }
        GameOver();
    }

    public void AddScore(int points)
    {
        if (gameHasEnded) return;

        score += points;
        scoreText.text = "Score     : " + score.ToString();
    }
    void GameOver()
    {
        gameHasEnded = true;
        totalScoreText.text = "Total Score: " + score.ToString();
        panelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
