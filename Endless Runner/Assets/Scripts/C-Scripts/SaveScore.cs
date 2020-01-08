using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScore : MonoBehaviour
{

    [SerializeField]WorldManagment worldScore;
    

    public void CheckHighScore()
    {
        if (!PlayerPrefs.HasKey("HighScore"))
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
