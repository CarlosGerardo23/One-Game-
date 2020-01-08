using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CoroutineMecanic/Jump")]
public class JumpMecanic : CoroutineMecanic
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
  

    bool jumping;

    public override void AndroidAction()
    {
        throw new System.NotImplementedException();
    }

    public override void UnityEditorAction()
    {
        CheckUnityMovement();
        CheckGorund();
        RotAnim();
    }
    /*   protected override void AndroidAction()
      {
          throw new System.NotImplementedException();
      }

      protected override void UnityEditorAction()
      {
          CheckUnityMovement();
          CheckGorund();
          RotAnim();
      } */
    private void CheckGorund()
    {
        if (playerObject.transform.position.y <= groundLimit && jumping)
        {

            currentsJumps = 0;
            jumping = false;
        }
    }
    private void CheckUnityMovement()
    {
        if(firstTime)
        {
            currentsJumps=0;
            firstTime=false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentsJumps < numberOfJumps)
        {
            CanCheckGround();
            currentsJumps += 1;

            float currentJumpVelocity = jumpVelocity / currentsJumps;


            playerRB.velocity = Vector2.up * currentJumpVelocity;
            Jump();        
        }

    }
    private IEnumerator CanCheckGround()
    {
        Debug.Log("Estoy en corrutina");
        yield return (new WaitForSeconds(.2f));
        jumping = true;
    }
    private void Jump()
    {
        if (playerRB.velocity.y < 0)
        {
            playerRB.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiper - 1) * Time.deltaTime;

        }
        else if (playerRB.velocity.y > 0 && !Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRB.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiper - 1) * Time.deltaTime;
        }
    }
    private void RotAnim()
    {
        playerObject.transform.Rotate(Vector3.forward * -20 * Time.deltaTime * 25);
    }


}
