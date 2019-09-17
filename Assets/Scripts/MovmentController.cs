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

    public float maxSpeed;

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
        body.angularVelocity = 0;
    }

    private void Move()
    {

        
        body.velocity += (Vector2) transform.up * accVal * moveSpeed * Time.deltaTime;



        if (body.velocity.magnitude > maxSpeed)
        {
            body.velocity = body.velocity.normalized * maxSpeed;
        }
    }
}
