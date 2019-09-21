using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Supplies : MonoBehaviour
{
    int Oxygen;
    int Water;
    int Food;
    int Energy;
    int OxygenStorage;
    int WaterStorage;
    int FoodStorage;
    int EnergyStorage;
    public int OxygenStorageModule = 50;
    public int WaterStorageModule = 50;
    public int FoodStorageModule = 50;
    public int EnergyStorageModule = 50;
    int OxygenStorageModuleAmount;
    int WaterStorageModuleAmount;
    int FoodStorageModuleAmount;
    int EnergyStorageModuleAmount;
    GameObject[] OxStorageModule;
    GameObject[] WaStorageModule;
    GameObject[] FoStorageModule;
    GameObject[] EnStorageModule;
    public Text OxygenText;
    public Text WaterText;
    public Text FoodText;
    public Text EnergyText;

    void Update()
    {
        //Finding Oxygen Storage Modules and Making sure that there isnt more Oxygen then the storage you have for it
        OxStorageModule = GameObject.FindGameObjectsWithTag("OxygenStorageModule");
        OxygenStorageModuleAmount = 0;
        foreach (GameObject O in OxStorageModule)
        {
            OxygenStorageModuleAmount += 1;
        }
        OxygenStorage = OxygenStorageModule * OxygenStorageModuleAmount;
        if (Oxygen >= OxygenStorage)
        {
            Oxygen = OxygenStorage;
        }
        if (Oxygen <= 0)
        {
            Oxygen = 0;
        }
        OxygenText.text = "Oxygen: " + Oxygen;
        //Finding Water Storage Modules and Making sure that there isnt more Water then the storage you have for it
        WaStorageModule = GameObject.FindGameObjectsWithTag("WaterStorageModule");
        WaterStorageModuleAmount = 0;
        foreach (GameObject A in WaStorageModule)
        {
            WaterStorageModuleAmount += 1;
        }
        WaterStorage = WaterStorageModule * WaterStorageModuleAmount;
        if (Water >= WaterStorage)
        {
            Water = WaterStorage;
        }
        if (Water <= 0)
        {
            Water = 0;
        }
        WaterText.text = "Water: " + Water;
        //Finding Food Storage Modules and Making sure that there isnt more Water then the Food you have for it
        FoStorageModule = GameObject.FindGameObjectsWithTag("FoodStorageModule");
        FoodStorageModuleAmount = 0;
        foreach (GameObject B in FoStorageModule)
        {
            FoodStorageModuleAmount += 1;
        }
        FoodStorage = FoodStorageModule * FoodStorageModuleAmount;
        if (Food >= FoodStorage)
        {
            Food = FoodStorage;
        }
        if (Food <= 0)
        {
            Food = 0;
        }
        FoodText.text = "Food: " + Food;
        //Finding Energy Storage Modules and Making sure that there isnt more Energy then the storage you have for it
        EnStorageModule = GameObject.FindGameObjectsWithTag("EnergyStorageModule");
        EnergyStorageModuleAmount = 0;
        foreach (GameObject C in EnStorageModule)
        {
            EnergyStorageModuleAmount += 1;
        }
        EnergyStorage = EnergyStorageModule * EnergyStorageModuleAmount;
        if (Energy >= EnergyStorage)
        {
            Energy = EnergyStorage;
        }
        if (Energy <= 0)
        {
            Energy = 0;
        }
        EnergyText.text = "Energy: " + Energy;
    }
    public void AddOxygen()
    {
        Oxygen += 1;
    }
    public void AddWater()
    {
        Water += 1;
    }
    public void AddFood()
    {
        Food += 1;
    }
    public void AddEnergy()
    {
        Energy += 1;
    }
}
