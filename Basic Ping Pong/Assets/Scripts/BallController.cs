using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    
    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        int rand = Random.Range(-1, 1);

        if(rand != 0)
        {
            rb.velocity = Vector2.left.normalized * speed;
        } else {
            rb.velocity = Vector2.right.normalized * speed;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Limiter"))
        {
            Destroy(gameObject);
        }
    }
}
