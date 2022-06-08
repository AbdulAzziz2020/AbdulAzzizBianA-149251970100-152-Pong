using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum PlayerState
    {
        Player1,
        Player2
    }

    public PlayerState currentState;
    public float speed;

    private Vector2 MovementUp;
    private Vector2 MovementDown;

    private void Update()
    {
        Movement();

        switch(currentState)
        {
            case PlayerState.Player1:
                Player1();
                break;
            case PlayerState.Player2:
                Player2();
                break;
        }
    }

    void Movement()
    {
        MovementUp = Vector2.up * speed * Time.deltaTime;
        MovementDown = Vector2.down * speed * Time.deltaTime;
    }

    void Player1()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(MovementUp);
        } 

        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(MovementDown);
        }
    }

    void Player2()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(MovementUp);
        }

        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(MovementDown);
        }
    }
}
