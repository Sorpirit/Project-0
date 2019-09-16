using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentController : MonoBehaviour
{
    public string HorizAxis;
    public string VertAxis;

    public float turnSpeed;
    public float moveSpeed;

    public Rigidbody2D body;

    public bool invert;

    private float turnVal;
    private float accVal;

    private void Update()
    {
        turnVal = -Input.GetAxis(HorizAxis);
        turnVal *= invert ? -1 : 1;
        accVal = Input.GetAxis(VertAxis);
    }

    private void FixedUpdate()
    { 
        Rotate();
        Move();
    }

    private void Rotate()
    {
        transform.Rotate(transform.forward,turnSpeed * turnVal);
    }

    private void Move()
    {
        body.velocity += (Vector2) transform.up * accVal * moveSpeed * Time.deltaTime;
    }
}
