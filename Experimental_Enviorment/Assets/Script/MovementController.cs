using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private Vector3 velocity;

    private void Start()
    {

    }

    private void Update()
    {
        transform.position += transform.rotation * velocity * Time.deltaTime;

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

        Rotate();
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0, Space.World);
        } else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
        }
    }
}
