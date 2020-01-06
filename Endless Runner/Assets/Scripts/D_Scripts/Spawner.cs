using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeBetweenSpawns;
    private float actualTimeBetween;
    public GameObject[] obstacles;


    // Update is called once per frame
    void Update()
    {
        if (actualTimeBetween <= 0)
        {
            int index = Random.Range(0, obstacles.Length-1);
            Debug.Log(index);
            Instantiate(obstacles[index], transform.position, obstacles[index].transform.rotation);
            actualTimeBetween = timeBetweenSpawns;
        }
        else
        {
            actualTimeBetween -= Time.deltaTime;
        }
    }
}
