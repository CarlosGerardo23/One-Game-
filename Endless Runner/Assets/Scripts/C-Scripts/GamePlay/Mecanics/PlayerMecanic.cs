using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMecanic : ScriptableObject
{
    protected MonoBehaviour playerObject;
    protected Rigidbody2D playerRB;

    protected bool firstTime;
    protected int currentPlatform;
    public void SetAction(MonoBehaviour playerObjectRefrence)
    {
        firstTime=true;
        currentPlatform = CheckPlatform();
        if (currentPlatform == -1)
        {
            Debug.LogError("No encuentro plataforma");
            return;
        }
        playerObject = playerObjectRefrence;
        playerRB = playerObjectRefrence.GetComponent<Rigidbody2D>();


    }
    int CheckPlatform()
    {
        if (!PlayerPrefs.HasKey("Platform"))
        {
            Debug.LogError("No encuntro plataforma");
            return -1;
        }
        return PlayerPrefs.GetInt("Platform");
    }
  
}
