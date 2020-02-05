using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed;
    private Vector3 velocity;

    private void Start()
    {

    }

    private void Update()
    {
        transform.position += velocity * Time.deltaTime;

        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            velocity = Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity = Vector3.back * speed;
        }
        else
        {
            velocity = Vector3.zero;
        }
    }
}
