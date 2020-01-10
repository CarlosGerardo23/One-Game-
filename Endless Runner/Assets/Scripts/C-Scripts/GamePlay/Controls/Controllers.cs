using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controllers : ScriptableObject
{
   public string nameReference;
   public abstract bool CheckInput();
}
