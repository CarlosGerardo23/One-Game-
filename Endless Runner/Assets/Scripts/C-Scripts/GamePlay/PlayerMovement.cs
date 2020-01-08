using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float fallMultiper = 2.5f;
    [SerializeField] float lowJumpMultiper = 2f;
    [SerializeField] int numberOfJumps;
    [SerializeField] float groundLimit;
    [Range(1, 100)]
    [SerializeField] float jumpVelocity;
    enum Plataform { ANDROID, UNITY }

    Plataform currentPlataform;
    [SerializeField] int currentsJumps = 0;
    Rigidbody2D rb;

    bool jumping;
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
        RotAnim();
    }

    private void CheckGorund()
    {
        if (gameObject.transform.position.y <= groundLimit && jumping)
        {

            currentsJumps = 0;
            jumping = false;
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
            StartCoroutine(CanCheckGround());
            currentsJumps += 1;

            float currentJumpVelocity = jumpVelocity / currentsJumps;


            rb.velocity = Vector2.up * currentJumpVelocity;
            Jump();
        }

    }
    private IEnumerator CanCheckGround()
    {
        yield return (new WaitForSeconds(.2f));
        jumping = true;
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
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiper - 1) * Time.deltaTime;
        }
    }

    private void RotAnim()
    {
        transform.Rotate(Vector3.forward * -20 * Time.deltaTime * 25);
    }


}
