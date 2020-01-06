using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSimple : MonoBehaviour
{
    public int speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
