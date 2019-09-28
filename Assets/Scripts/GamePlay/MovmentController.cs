using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentController : MonoBehaviour
{
    public TakeFuel take;

    public string HorizAxis;
    public string VertAxis;

    public float turnSpeed;
    public float accSpeed;
    public float decSpeed;

    public float maxSpeed;

    public Rigidbody2D body;

    public bool invertInput;
    public bool autoBalance;

    private float turnVal;
    private float accVal;

    private void Update()
    {
        turnVal = -Input.GetAxis(HorizAxis);
        turnVal *= invertInput ? -1 : 1;
        accVal = Input.GetAxis(VertAxis);
        accVal *= invertInput ? -1 : 1;
    }

    private void FixedUpdate()
    { 
        Rotate();

        if(!take.isTankEmpty())
            Move();
    }

    private void Rotate()
    {
        //transform.Rotate(transform.up, turnSpeed * turnVal);
        //transform.eulerAngles += Vector3.forward * ;
        // = ;
        //Quaternion.FromToRotation(transform.up, Vector3.forward * turnSpeed * turnVal);
        transform.up = Quaternion.Euler(0,0,turnVal * turnSpeed) * transform.up;
    }

    private void Move()
    {
        body.velocity += (Vector2) transform.up * accVal * accSpeed * Time.deltaTime;

        take.UseFuel(accVal);

        if (autoBalance && accVal == 0) AutoBalanceSpeed();

        if (body.velocity.magnitude > maxSpeed)
        {
            body.velocity = body.velocity.normalized * maxSpeed;
        }
    }

    private void AutoBalanceSpeed()
    {
        body.velocity += (Vector2) (-body.velocity.normalized) * decSpeed * Time.deltaTime;

        if (body.velocity.magnitude < 0.2f) body.velocity = Vector2.zero;
    }
}
