using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        transform.position.Set(transform.position.x, Random.Range(-2, 2), 0);
    }

    void Update()
    {
        if (transform.position.x == -10)
        {
            transform.position = new Vector2(10, 0);
            transform.position.Set(transform.position.x, Random.Range(-2, 2), 0);
        }
    }
}
