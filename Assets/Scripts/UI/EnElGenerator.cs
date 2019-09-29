using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnElGenerator : MonoBehaviour
{
    int DobleChek1;
    int DobleChek2;

    int Chek1;
    int Chek2;

    public Supplies supplies;
    public Fuels fuels;

    float elapsed0 = 0f;
    float elapsed1 = 0f;

    public bool MakeEnergy;
    public bool MakeElectric;

    private void Update()
    {
        Optimize();
        ChekingEnEl();
        ChekingElEn();
        Chek1 = 0;
        Chek2 = 0;
        if (MakeEnergy == true)
        {
            elapsed0 += Time.deltaTime;
            if (elapsed0 >= 1f)
            {
                elapsed0 = elapsed0 % 1f;
                ElToEn();
            }
        }
        if (MakeElectric == true)
        {
            elapsed1 += Time.deltaTime;
            if (elapsed1 >= 1f)
            {
                elapsed1 = elapsed1 % 1f;
                EnToEl();
            }
        }
    }
    void EnToEl()
    {
        if (fuels.ElectricStorage > fuels.ChekEl)
        {
            if (Chek1 <= 1)
            {
                supplies.TakeEnergy();
                fuels.AddElectric();
            }
        }
    }
    void ElToEn()
    {
        if (supplies.EnergyStorage > supplies.ChekEn)
        {
            if (Chek2 <= 1)
            {
                supplies.AddEnergy();
                fuels.TakeElectric();
            }
        }
    }
    void ChekingElEn()
    {
        if (fuels.ChekEl <= 0)
        {
            DobleChek1 = 0;
        }
        if (fuels.ChekEl >= 1)
        {
            DobleChek1 = 1;
        }
        if (fuels.ChekEl >= 1)
        {
            Chek1 += fuels.ChekEl * DobleChek1;
        }
    }
    void ChekingEnEl()
    {
        if (supplies.ChekEn <= 0)
        {
            DobleChek2 = 0;
        }
        if (supplies.ChekEn >= 1)
        {
            DobleChek2 = 1;
        }
        if (supplies.ChekEn >= 1)
        {
            Chek2 += supplies.ChekEn * DobleChek2;
        }
    }
    void Optimize()
    {
        if (MakeEnergy == true)
        {
            if (MakeElectric == true)
            {
                MakeElectric = false;
                MakeEnergy = false;
            }
        }
    }
}
