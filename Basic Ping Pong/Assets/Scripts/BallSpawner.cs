using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;

    [Header("Ball Controller")]
    public float speed;

    private void Start()
    {
        Instantiate(ball, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("ball") == null)
        {
            Instantiate(ball, transform.position, Quaternion.identity);
        }
    }
}
