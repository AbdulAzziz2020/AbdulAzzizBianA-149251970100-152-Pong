using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        ScoreManager.scorePlayer1 = 0;
        ScoreManager.scorePlayer2 = 0;

        Debug.Log("Created by Abdul Azziz Bian A - 149251970100-152");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        ScoreManager.scorePlayer1 = 0;
        ScoreManager.scorePlayer2 = 0;
    }

    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
