using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAlient : MonoBehaviour
{
    float Ali;
    float elapsed = 0f;
    public GameObject Sup;
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 60f)
        {
            elapsed = elapsed % 1f;
            Sup.GetComponent<Supplies>().TakeOxygen();
            Sup.GetComponent<Supplies>().TakeWater();
            Sup.GetComponent<Supplies>().TakeFood();
            Sup.GetComponent<Supplies>().TakeEnergy();
        }
    }
}