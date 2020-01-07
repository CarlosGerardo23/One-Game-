using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowScore : MonoBehaviour
{
    [SerializeField]Text score_txt;
    [SerializeField]WorldManagment scoreRefrence;


    // Update is called once per frame
    void Update()
    {
        score_txt.text=scoreRefrence.score.ToString();
    }
}
