using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Controllers/AxisController")]
public class AxisController : Controllers
{
    public override bool CheckInput()
    {
       
        if(Input.GetAxis(nameReference)==1)
        return true;
         
        return false;
    }
}

