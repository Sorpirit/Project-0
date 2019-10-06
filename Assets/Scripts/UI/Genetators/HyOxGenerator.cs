using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyOxGenerator : MonoBehaviour
{
    int ChekEnWa;
    int DobleChek;

    public Supplies supplies;
    public Fuels fuels;
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



}
