using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Controllers/AxisController")]
public class AxisController : Controls
{
    public override bool CheckInput()
    {
       
        if(Input.GetAxis(axisReference)==1)
        return true;
        else 
        return false;
    }
}

