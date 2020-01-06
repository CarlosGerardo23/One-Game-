using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSimple : MonoBehaviour
{
    public int speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
        if (transform.rotation.z < 0)
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime * 25);
        }
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
