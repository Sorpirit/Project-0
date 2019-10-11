using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Alien : MonoBehaviour
{
    public int speed = 20;

    private Rigidbody2D rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Invoke("MoveRand", 3);
        InvokeRepeating("MoveRand", 1, 3);
    }

    private void MoveRand() {
        Debug.Log("Move");
        rb.velocity = Random.insideUnitCircle * speed * Time.deltaTime;
    }
}
