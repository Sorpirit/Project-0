using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : Upgradeable
{
    private int maxCapacity;
    private float storage;
    private int level;

    public Storage(int capacity,bool fillStarage = false)
    {
        maxCapacity = capacity;
        storage = fillStarage ? maxCapacity : 0;
        level = 1;
    }

    public int Capacity { get { return maxCapacity; } }
    public float StroageVal
    {
        get { return storage; }
        set {
            storage = value;

            if (storage > maxCapacity) storage = maxCapacity;
            if (storage < 0) storage = 0;
        }
    }
    public int Level { get { return level; } }

    private bool ChekRes(float storage)
    {
        return storage < 0 || storage > maxCapacity;
    }

    public int GetLevel()
    {
        return level;
    }

    public void Upgrade()
    {
        level++;
        maxCapacity += level * 10;
        
    }
}
