using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerData : MonoBehaviour
{
    public int score = 0;
    [SerializeField] int life;

    [SerializeField] UnityEvent playerDie;
    void OnTriggerEnter2D(Collider2D collision)
    {
        life -= 1;

        if (life <= 0)
        {
            playerDie.Invoke();
        }
    }

    public void AddScore(int newScore)
    {
        score+=newScore;
    }
}
