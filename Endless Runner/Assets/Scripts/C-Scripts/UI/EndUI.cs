using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndUI : MonoBehaviour
{
    [SerializeField]Text highScore_txt; 
    [SerializeField]Text currentScore_txt; 
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("CurrentScore"))
        currentScore_txt.text=PlayerPrefs.GetInt("CurrentScore").ToString();
        if(PlayerPrefs.HasKey("HighScore"))
        highScore_txt.text=PlayerPrefs.GetInt("HighScore").ToString();
    }

    

}
