using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFuel : MonoBehaviour
{ 
    public int maxFuel;
    private float fuel;

    public bool isDebuging;

    private void Awake()
    {
        fuel = maxFuel;
    }

    public void UseFuel(float value)
    {
        fuel -= Time.deltaTime * value;
        if (fuel < 0) fuel = 0;
    }

    public void AddFuel(float value)
    {
        fuel += value;

        if (fuel > maxFuel) fuel = maxFuel;
    }

    public bool isTankEmpty()
    {
        return fuel <= 0;
    }

    private void LateUpdate()
    {
        if (isDebuging) Debuging();
    }

    private void Debuging()
    {
        Debug.Log("mfuel = " + maxFuel + " .\nFule = "+ fuel +".");
    }

}
