using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controls : ScriptableObject
{
    public string axisReference;
   public abstract bool CheckInput();
}
