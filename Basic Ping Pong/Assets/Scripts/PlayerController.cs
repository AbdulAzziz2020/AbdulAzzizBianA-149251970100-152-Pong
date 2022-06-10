using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public KeyCode upCode;
    public KeyCode downCode;
    public float mapWidth;

    private float moveInput;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if(Input.GetKey(upCode))
        {
            moveInput = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
            Vector2 newPosition = rb.position + Vector2.up * moveInput;
            newPosition.y = Mathf.Clamp(newPosition.y, -mapWidth, mapWidth);
            rb.MovePosition(newPosition);
            
        } else if(Input.GetKey(downCode)) {
            moveInput = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
            Vector2 newPosition = rb.position + Vector2.up * moveInput;
            newPosition.y = Mathf.Clamp(newPosition.y, -mapWidth, mapWidth);
            rb.MovePosition(newPosition);
        }
        
    }
}
