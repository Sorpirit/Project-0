using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoGenerator : MonoBehaviour
{
    int DobleChek;

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
        if (supplies.ChekFo < supplies.FoodStorage - 2)
        {
            if (supplies.ChekEn >= 1)
            {
                if (supplies.ChekOx >= 1)
                {
                    if (supplies.ChekWa >= 1)
                    {
                        if (supplies.FoodStorage > supplies.ChekFo)
                        {
                            supplies.TakeEnergy();
                            supplies.TakeOxygen();
                            supplies.TakeWater();
                            supplies.AddFood();
                            supplies.AddFood();
                            supplies.AddFood();
                        }
                    }
                }
            }
        }
    }
}