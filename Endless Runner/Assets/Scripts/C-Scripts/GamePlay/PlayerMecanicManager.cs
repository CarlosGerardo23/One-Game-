using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMecanicManager : MonoBehaviour
{
    [SerializeField]CoroutineMecanic mecanic;
    // Start is called before the first frame update
    void Start()
    {
        mecanic.SetAction(this);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(mecanic.DoAction());
    }
}
