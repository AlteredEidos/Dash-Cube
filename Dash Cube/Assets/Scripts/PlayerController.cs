using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ParticleSystem jump;
    [SerializeField] ParticleSystem death;
    Rigidbody2D rB;

    public bool isDead;
    [SerializeField] float jumpForce;
    int score;

    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.Play();
            rB.velocity = Vector2.zero;
            rB.AddForce(new Vector2 (0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            isDead = true;
            Death();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            score++;
        }
    }

    void Death()
    {
        death.Play();
        Destroy(gameObject, 0.1f);
    }
}
