using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScore : MonoBehaviour
{

    WorldManagment worldScore;
    void Start()
    {
        worldScore = GetComponent<WorldManagment>();
    }

    public void CheckHighScore()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            int currentHighScore = PlayerPrefs.GetInt("HighScore");
            if (worldScore.score > currentHighScore)
                PlayerPrefs.SetInt("HighScore", worldScore.score);
            PlayerPrefs.SetInt("CurrentScore", worldScore.score);
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", worldScore.score);
            PlayerPrefs.SetInt("CurrentScore", worldScore.score);
        }
        PlayerPrefs.Save();
    }
}
