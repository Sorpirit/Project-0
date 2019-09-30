using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuppliesNew : MonoBehaviour
{
    int Metal = 10;
    int MetalStorage = 50;
    public void Upgrade()
    {
        MetalStorage += 10;
    }
    public void AddMetal()
    {
        if (Metal < MetalStorage)
        {
            Metal += 1;
        }
    }
    public void TakeMetal()
    {
        if (Metal > 0)
        {
            Metal -= 1;
        }
    }
    public void UpgradeFromLvl5()
    {
        Upgrade();
        Upgrade();
        Upgrade();
        Upgrade();
        Upgrade();
    }
}
