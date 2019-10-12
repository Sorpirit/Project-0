using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliensSimulation : MonoBehaviour
{
    public int statrtAliensCount = 1;
    [Range(0f,10f)]public int simulationSpeed = 1;

    private int aliensCount;
    private const int tickRate = 2;
    [SerializeField]private float resMult = 1;
    [SerializeField]private Supplies supplies;

    [SerializeField]private GameObject alien;
    private List<GameObject> aliens;

    private float simulationTimer;

    private void Start()
    {
        aliensCount = statrtAliensCount;
        aliens = new List<GameObject>();
        for(int al = 0; al < statrtAliensCount; al++)
        {

            spawnNewAlien();
        }
    }

    private void Update()
    {
        //aliens = GameObject.FindGameObjectsWithTag("Alient"); !!!!!!
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
            for(int al = 0; al < aliansTokill; al++)
            {
                killRandAlien();
            }
        }

        supplies.TakeAll(resMult * aliensCount);
    }
    private void spawnNewAlien()
    {
        GameObject newAlien = Instantiate(alien,transform.position, Quaternion.identity);
        aliens.Add(newAlien);
        takeRandRes(5);
    }
   

    private void killRandAlien()
    {
        int index = Random.Range(0, aliens.Count);
        Destroy(aliens[index]);
        aliens.RemoveAt(index);
    }
    private void takeRandRes(int val)
    {
        int index = Random.Range(0, 3);
        switch (index)
        {
            case 0:
                supplies.WaStorageModule.StroageVal -= val;
                break;
            case 1:
                supplies.OxStorageModule.StroageVal -= val;
                break;
            case 2:
                supplies.FoStorageModule.StroageVal -= val;
                break;
            case 3:
                supplies.EnStorageModule.StroageVal -= val;
                break;
        }
    }
}
