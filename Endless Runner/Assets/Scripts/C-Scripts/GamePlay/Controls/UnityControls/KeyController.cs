using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Controllers/KeyController")]
public class KeyController : Controllers
{
    [SerializeField] UnityEngine.KeyCode key;
    public override bool CheckInput()
    {
        if (Input.GetKeyDown(key))
            return true;
        return false;
    }
}
