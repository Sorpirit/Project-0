using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnElGenerator : MonoBehaviour
{

    public Supplies supplies;
    public Fuels fuels;

    public float generatRate = 1f;
    private float timer;

    public bool MakeEnergy;
    public bool MakeElectric;

    public float enPreSecond;
    public float elPreSecond;

    private void Update()
    {
        Optimize();
        timer += Time.deltaTime;

        if (timer >= generatRate)
        {
            if (MakeEnergy)
            {
                ElToEn();
            }
            else if (MakeElectric)
            {
                EnToEl();
            }

            timer = 0f;
        }
    }

    void EnToEl()
    {
        supplies.EnStorageModule.StroageVal -= elPreSecond;

    }

    void ElToEn()
    {

        supplies.EnStorageModule.StroageVal += enPreSecond;
    }


    void Optimize()
    {

        /*
        if (MakeEnergy == true)
        {
            if (MakeElectric == true)
            {
                MakeElectric = false;
                MakeEnergy = false;
            }
        }
        */
        //Better use && [and]. 
        //And boos we never chek like this MakeEnergy == true.
        //Better write just (MakeEnergy) for MakeEnergy == true and (!MakeEnergy) for MakeEnergy == false

        if (MakeEnergy && MakeElectric)
        {
            MakeElectric = false;
            MakeEnergy = false;
        }

    }
}
