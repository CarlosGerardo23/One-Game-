﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float fallMultiper = 2.5f;
    [SerializeField] float lowJumpMultiper = 2f;
    [SerializeField] int numberOfJumps;
    [SerializeField] float groundLimit;
    [Range(1, 10)]
    [SerializeField] float jumpVelocity;
    enum Plataform { ANDROID, UNITY }

    Plataform currentPlataform;
    int currentsJumps = 1;
    Rigidbody2D rb;

    void Start()
    {
#if UNITY_EDITOR
        {
            Debug.Log("Estoy en el editor");
            currentPlataform = Plataform.UNITY;
        }
#elif UNITY_ANDROID
        {
            //Debugg en adroid
            currentPlataform=Plataform.ANDROID;
        }
#endif
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        CheckMovement(currentPlataform);
        CheckGorund();
    }

    private void CheckGorund()
    {
        if (gameObject.transform.position.y <= groundLimit)
        {

            currentsJumps = 1;
        }
    }

    private void CheckMovement(Plataform currentPlataform)
    {

        switch (currentPlataform)
        {
            case Plataform.UNITY:
                CheckUnityMovement();
                break;
            case Plataform.ANDROID:
                CheckAndroidMovement();
                break;
        }
    }

    private void CheckUnityMovement()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) && currentsJumps < numberOfJumps)
        {
            float currentJumpVelocity=jumpVelocity/currentsJumps;
            currentsJumps += 1;
            rb.velocity = Vector2.up * currentJumpVelocity;
            Jump();
        }
        /* if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        } */
    }
    private void CheckAndroidMovement()
    {

    }

    private void Jump()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiper - 1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiper - 1) * Time.deltaTime;
        }
    }


}
