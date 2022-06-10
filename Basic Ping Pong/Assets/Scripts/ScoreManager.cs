using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scorePlayer1Text;
    public TMP_Text scorePlayer2Text;

    public static int scorePlayer1 = 0;
    public static int scorePlayer2 = 0;

    public TMP_Text winnerText;
    public GameObject finishPanel;

    private int maxScore = 9;

    private void Start()
    {
        finishPanel.SetActive(false);
        scorePlayer1Text.text = scorePlayer1.ToString();
        scorePlayer2Text.text = scorePlayer2.ToString();
    }

    private void Update()
    {
        ScorePlayer1();
        ScorePlayer2();
    }

    void ScorePlayer1()
    {
        scorePlayer1Text.text = scorePlayer1.ToString();
        if (scorePlayer1 > maxScore)
        {
            Time.timeScale = 0;
            finishPanel.SetActive(true);
            winnerText.text = "Winner Player 1";
        }
    }

    void ScorePlayer2()
    {
        scorePlayer2Text.text = scorePlayer2.ToString();
        if (scorePlayer2 > maxScore)
        {
            Time.timeScale = 0;
            finishPanel.SetActive(true);
            winnerText.text = "Winner Player 2";
        }
    }
}
