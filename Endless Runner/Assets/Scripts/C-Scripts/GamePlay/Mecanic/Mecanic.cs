﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mecanic : ScriptableObject
{
    protected MonoBehaviour player;
    public void InitializeMecanic(MonoBehaviour objectReference)
    {
        player = objectReference;
    }

    public abstract void DoMecanic();
    
}
