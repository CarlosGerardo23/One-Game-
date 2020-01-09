﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "2DMecanic/Jump")]
public class JumpMecanic : Mecanic
{
    [SerializeField] float fallMultiper = 2.5f;
    [SerializeField] float lowJumpMultiper = 2f;
    [SerializeField] int numberOfJumps;
    [SerializeField] float groundLimit;
    [Range(1, 100)]
    [SerializeField] float jumpVelocity;
    [SerializeField] int currentsJumps = 0;
    Rigidbody2D rb;

    public override void DoMecanic()
    {
        CheckMovement();
        CheckGorund();
        RotAnim();
    }
    private void CheckGorund()
    {
        if (player.transform.position.y == groundLimit)
            currentsJumps = 0;
    }
    private void Jump()
    {
        if (rb.velocity.y < 0)
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiper - 1) * Time.deltaTime;
        else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.UpArrow))
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiper - 1) * Time.deltaTime;

    }

    private void CheckMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentsJumps < numberOfJumps)
        {
            currentsJumps += 1;
            float currentJumpVelocity = jumpVelocity / currentsJumps;
            rb.velocity = Vector2.up * currentJumpVelocity;
            Jump();
        }
    }

    private void RotAnim()
    {
        player.transform.Rotate(Vector3.forward * -20 * Time.deltaTime * 25);
    }
}
