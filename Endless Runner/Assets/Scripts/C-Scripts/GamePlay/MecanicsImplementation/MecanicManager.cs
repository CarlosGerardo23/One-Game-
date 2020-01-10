using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicManager : MonoBehaviour
{
    [SerializeField]MecanicData data;
    // Start is called before the first frame update
    void Start()
    {
        data.SetAllMecanics(this);
    }

    // Update is called once per frame
    void Update()
    {
        data.CheckAllMecanics();
    }
}
