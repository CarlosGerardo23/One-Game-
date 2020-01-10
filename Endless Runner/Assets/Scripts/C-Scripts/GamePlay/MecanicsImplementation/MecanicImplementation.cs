using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MecanicImplementation
{
    [SerializeField] Controllers controls;
    [SerializeField] Mecanic mecanic;

    public void SetMecanic(MonoBehaviour objectReference)
    {
        mecanic.InitializeMecanic(objectReference);
    }
    public void CheckMecanic()
    {
        if (controls.CheckInput())
            mecanic.DoMecanic();
    }
}
