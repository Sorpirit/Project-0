using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyOxGenerator : MonoBehaviour
{
    public GameObject Sup;
    public GameObject Fuel;
    public GameObject HyOxLvl0;
    public GameObject HyOxLvl1;
    public GameObject HyOxLvl2;
    public GameObject HyOxLvl3;
    public GameObject HyOxLvl4;
    public GameObject HyOxLvl5;
    public GameObject HyOxLvl6;

    float elapsed0 = 0f;
    float elapsed1 = 0f;
    float elapsed2 = 0f;
    float elapsed3 = 0f;
    float elapsed4 = 0f;
    float elapsed5 = 0f;
    float elapsed6 = 0f;

    public bool HyOxBool0;
    public bool HyOxBool1;
    public bool HyOxBool2;
    public bool HyOxBool3;
    public bool HyOxBool4;
    public bool HyOxBool5;
    public bool HyOxBool6;

    private void Start()
    {
        HyOxLvl0.SetActive(false);
        HyOxLvl1.SetActive(false);
        HyOxLvl2.SetActive(false);
        HyOxLvl3.SetActive(false);
        HyOxLvl4.SetActive(false);
        HyOxLvl5.SetActive(false);
        HyOxLvl6.SetActive(false);

        HyOxBool0 = false;
        HyOxBool1 = false;
        HyOxBool2 = false;
        HyOxBool3 = false;
        HyOxBool4 = false;
        HyOxBool5 = false;
        HyOxBool6 = false;
    }
    void Update()
    {
        if (HyOxBool0 == true)
        {
            elapsed0 += Time.deltaTime;
            if (elapsed0 >= 60f)
            {
                elapsed0 = elapsed0 % 1f;
                Sup.GetComponent<Supplies>().TakeWater();
                Fuel.GetComponent<Fuels>().TakeElectric();
                Fuel.GetComponent<Fuels>().AddHydrogen();
                Sup.GetComponent<Supplies>().AddOxygen();
            }
        }
        if (HyOxBool1 == true)
        {
            elapsed1 += Time.deltaTime;
            if (elapsed2 >= 30f)
            {
                elapsed2 = elapsed2 % 1f;
                Sup.GetComponent<Supplies>().TakeWater();
                Fuel.GetComponent<Fuels>().TakeElectric();
                Fuel.GetComponent<Fuels>().AddHydrogen();
                Sup.GetComponent<Supplies>().AddOxygen();
            }
        }
        if (HyOxBool2 == true)
        {
            elapsed2 += Time.deltaTime;
            if (elapsed2 >= 10f)
            {
                elapsed2 = elapsed2 % 1f;
                Sup.GetComponent<Supplies>().TakeWater();
                Fuel.GetComponent<Fuels>().TakeElectric();
                Fuel.GetComponent<Fuels>().AddHydrogen();
                Sup.GetComponent<Supplies>().AddOxygen();
            }
        }
        if (HyOxBool3 == true)
        {
            elapsed3 += Time.deltaTime;
            if (elapsed3 >= 5f)
            {
                elapsed3 = elapsed3 % 1f;
                Sup.GetComponent<Supplies>().TakeWater();
                Fuel.GetComponent<Fuels>().TakeElectric();
                Fuel.GetComponent<Fuels>().AddHydrogen();
                Sup.GetComponent<Supplies>().AddOxygen();
            }
        }
        if (HyOxBool4 == true)
        {
            elapsed4 += Time.deltaTime;
            if (elapsed4 >= 2f)
            {
                elapsed4 = elapsed4 % 1f;
                Sup.GetComponent<Supplies>().TakeWater();
                Fuel.GetComponent<Fuels>().TakeElectric();
                Fuel.GetComponent<Fuels>().AddHydrogen();
                Sup.GetComponent<Supplies>().AddOxygen();
            }
        }
        if (HyOxBool5 == true)
        {
            elapsed5 += Time.deltaTime;
            if (elapsed5 >= 1f)
            {
                elapsed5 = elapsed5 % 1f;
                Sup.GetComponent<Supplies>().TakeWater();
                Fuel.GetComponent<Fuels>().TakeElectric();
                Fuel.GetComponent<Fuels>().AddHydrogen();
                Sup.GetComponent<Supplies>().AddOxygen();
            }
        }
        if (HyOxBool6 == true)
        {
            elapsed6 += Time.deltaTime;
            if (elapsed6 >= 0.5f)
            {
                elapsed6 = elapsed6 % 1f;
                Sup.GetComponent<Supplies>().TakeWater();
                Fuel.GetComponent<Fuels>().TakeElectric();
                Fuel.GetComponent<Fuels>().AddHydrogen();
                Sup.GetComponent<Supplies>().AddOxygen();
            }
        }
    }
}
