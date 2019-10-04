using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliensSimulation : MonoBehaviour
{
    public int statrtAliensCount = 1;
    [Range(0f,10f)]public int simulationSpeed = 1;

    private int aliensCount;
    private const int tickRate = 60;
    [SerializeField]private float resMult = 1;
    [SerializeField]private Supplies supplies;

    private float simulationTimer;

    private void Start()
    {
        aliensCount = statrtAliensCount;
    }

    private void Update()
    {
        simulationTimer += Time.deltaTime * simulationSpeed;

        if(simulationTimer >= tickRate)
        {
            if(aliensCount > 0) useRes();
            simulationTimer = 0f;
        }
    }

    private void useRes()
    {
        //find min supp
        float supp = Mathf.Min(supplies.OxStorageModule.StroageVal, supplies.WaStorageModule.StroageVal, 
            supplies.FoStorageModule.StroageVal, supplies.EnStorageModule.StroageVal);

        int aliansTokill = (int) (-(supp - resMult * aliensCount) / resMult);

        if(aliansTokill > 0)
        {
            Debug.Log("Kill:" + aliansTokill);
            aliensCount -= aliansTokill;
        }

        supplies.TakeAll(resMult * aliensCount);
    }
}
