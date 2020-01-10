using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Controllers/ButtonController")]
public class ButtonController : Controllers
{
    public override bool CheckInput()
    {
       
        if (Input.GetButtonDown(nameReference))
            return true;

        return false;
    }
}
