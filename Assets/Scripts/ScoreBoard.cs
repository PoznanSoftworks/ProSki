using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;                                                        // The System.IO namespace contains functions related to loading and saving files

public class ScoreBoard : MonoBehaviour
{
    private Player playerProgress;

    private string gameDataFileName = "data.json";



    public void SubmitNewPlayerScore(int newScore)
    {
        // If newScore is greater than playerProgress.highestScore, update playerProgress with the new value and call SavePlayerProgress()
        if (newScore > playerProgress.points)
        {
            playerProgress.points = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighestPlayerScore()
    {
        return playerProgress.points;
    }



    private void LoadPlayerInfo()
    {
        playerProgress = new Player();

             if (PlayerPrefs.HasKey("highestScore"))
        {
            playerProgress.points = PlayerPrefs.GetInt("highestScore");
        }
    }

     private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("highestScore", playerProgress.points);
    }
}