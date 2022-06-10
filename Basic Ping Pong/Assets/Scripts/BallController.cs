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
       StartCoroutine(BallMovement());
        Debug.Log("Ball Speed : " + speed);
    }

    IEnumerator BallMovement()
    {
        yield return new WaitForSeconds(1f);

        int rand = Random.Range(-1, 1);

        if (rand != 0)
        {
            Vector2 dir = Vector2.left;
            dir.y = Random.Range(-0.67f, 0.67f);
            rb.velocity = dir.normalized * speed;
        }
        else
        {
            Vector2 dir = Vector2.right;
            dir.y = Random.Range(-0.67f, 0.67f);
            rb.velocity = dir.normalized * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Limiter P1"))
        {
            ScoreManager.scorePlayer2++;
            Destroy(gameObject);
            
        } else if(collision.gameObject.CompareTag("Limiter P2")) {
            ScoreManager.scorePlayer1++;
            Destroy(gameObject);
        }
    }
}
