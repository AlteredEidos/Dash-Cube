using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed;
    public int randomRatio;
    Vector2 random;

    void Start()
    {
        random = new Vector2(transform.position.x, Random.Range(-randomRatio, randomRatio));
        transform.position = random;
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (transform.position.x <= -10)
        {
            Randomize();
        }
    }

    void Randomize()
    {
        random = new Vector2(20, Random.Range(-randomRatio, randomRatio));
        transform.position = random;
    }
}
