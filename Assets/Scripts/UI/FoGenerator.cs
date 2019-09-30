using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoGenerator : MonoBehaviour
{
    public Supplies supplies;
    public Fuels fuels;

    float elapsed0 = 0f;

    public bool FoodBool0;

    private void Start()
    {
        FoodBool0 = false;
    }
    void Update()
    {
        if (FoodBool0 == true)
        {
            elapsed0 += Time.deltaTime;
            if (elapsed0 >= 2f)
            {
                elapsed0 = elapsed0 % 1f;
                GenerateHyOx();
            }
        }
    }
    void GenerateHyOx()
    {
        
    }
}