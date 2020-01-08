using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CoroutineMecanic : PlayerMecanic
{
    
    public IEnumerator DoAction()
    {
        if (currentPlatform == -1)
        {
            Debug.LogError("No encuentro llave de plataforma");
            yield return new WaitForSeconds(0);
        }

        if (currentPlatform == 0)
          UnityEditorAction();
        else
          AndroidAction();
    }
    public abstract void AndroidAction();
    public abstract void UnityEditorAction();
}
