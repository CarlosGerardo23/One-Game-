﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManagment : MonoBehaviour
{
   
    public int score;

    void Start()
    {
        StartCoroutine(StartTimer());
    }
    IEnumerator StartTimer()
    {
        int scoreToAdd = GetScore();
        float timeToWait= GetTime();
        yield return new WaitForSeconds(timeToWait);
        AddScore(scoreToAdd);
    }

    private int GetScore()
    {
        return UnityEngine.Random.Range(50,70);
    }
    private float GetTime()
    {
        return UnityEngine.Random.Range(10f,15f);
    }
    private void AddScore(int newScore)
    {
        score+=newScore;
        StartCoroutine(StartTimer());
    }
}
