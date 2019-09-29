using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Supplies : MonoBehaviour
{
    public GameObject DethUI;

    int Oxygen = 10;
    int Water = 20;
    int Food = 20;
    int Energy = 20;
    int AlientAmount;

    public int ChekSup;
    public int ChekOx;
    public int ChekWa;
    public int ChekFo;
    public int ChekEn;

    public int OxygenStorage;
    public int WaterStorage;
    public int FoodStorage;
    public int EnergyStorage;
    int AlientStorage;

    public int OxygenStorageModule = 50;
    public int WaterStorageModule = 50;
    public int FoodStorageModule = 50;
    public int EnergyStorageModule = 50;
    public int AlientStorageModule = 50;

    int OxygenStorageModuleAmount;
    int WaterStorageModuleAmount;
    int FoodStorageModuleAmount;
    int EnergyStorageModuleAmount;
    int AlientStorageModuleAmount;

    GameObject[] OxStorageModule;
    GameObject[] WaStorageModule;
    GameObject[] FoStorageModule;
    GameObject[] EnStorageModule;
    GameObject[] AlStorageModule;
    GameObject[] AllAlients;

    GameObject Alient;
    int index;
    int OldAli = 0;

    public Text OxygenText;
    public Text WaterText;
    public Text FoodText;
    public Text EnergyText;
    public Text AlientText;

    void Update()
    {
        ChekingSup();
        if (AlientAmount <= OldAli - 1)
        {
            index = Random.Range(0, AllAlients.Length);
            AlientAmount = OldAli;
        }
        AllAlients = GameObject.FindGameObjectsWithTag("Alient");
        if (AlientAmount >= 2)
        {
            Alient = AllAlients[index];
        }
        if (AlientAmount <= 1)
        {
            Alient = GameObject.FindGameObjectWithTag("Alient");
        }
        if (index <= -1)
        {
            index = 0;
        }
        AlientAmount = 0;
        foreach (GameObject K in AllAlients)
        {
            AlientAmount += 1;
        }
        AlStorageModule = GameObject.FindGameObjectsWithTag("AlientStorageModule");
        AlientStorageModuleAmount = 0;
        foreach (GameObject L in AlStorageModule)
        {
            AlientStorageModuleAmount += 1;
        }
        AlientStorage = AlientStorageModule * AlientStorageModuleAmount;
        if (AlientAmount >= AlientStorage)
        {
            AlientAmount = AlientStorage;
        }
        if (AlientAmount <= 0)
        {
            AlientAmount = 0;
        }
        AlientText.text = "Alients: " + AlientAmount;
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
        JustDie();
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
    public void TakeOxygen()
    {
        if (Oxygen >= 1)
        {
            Oxygen -= 1;
        }
    }
    public void TakeWater()
    {
        if (Water >= 1)
        {
            Water -= 1;
        }
    }
    public void TakeFood()
    {
        if (Food >= 1)
        {
            Food -= 1;
        }
    }
    public void TakeEnergy()
    {
        if (Energy >= 1)
        {
            Energy -= 1;
        }
    }
    public void JustDie()
    {
        if (Oxygen < AlientAmount)
        {
            if (AlientAmount > Oxygen)
            {
                Destroy(Alient);
            }
            if (Oxygen == 0)
            {
                foreach (GameObject go in AllAlients)
                {
                    Destroy(go);
                }
                AlientAmount = 0;
            }
            if (AlientAmount <= 0)
            {
                DethUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        if (Water < AlientAmount)
        {
            if (AlientAmount > Water)
            {
                Destroy(Alient);
            }
            if (Water == 0)
            {
                foreach (GameObject go in AllAlients)
                {
                    Destroy(go);
                }
                AlientAmount = 0;
            }
            if (AlientAmount <= 0)
            {
                DethUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        if (Food < AlientAmount)
        {
            if (AlientAmount > Food)
            {
                Destroy(Alient);
            }
            if (Food == 0)
            {
                foreach (GameObject go in AllAlients)
                {
                    Destroy(go);
                }
                AlientAmount = 0;
            }
            if (AlientAmount <= 0)
            {
                DethUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        if (Energy < AlientAmount)
        {
            if (AlientAmount > Energy)
            {
                Destroy(Alient);
            }
            if (Energy == 0)
            {
                foreach (GameObject go in AllAlients)
                {
                    Destroy(go);
                }
                AlientAmount = 0;
            }
            if (AlientAmount <= 0)
            {
                DethUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
    public void ChekingSup()
    {
        if (Oxygen == 0)
        {
            ChekSup = 0;
            ChekOx = 0;
        }
        if (Water == 0)
        {
            ChekSup = 0;
            ChekWa = 0;
        }
        if (Food == 0)
        {
            ChekSup = 0;
            ChekFo = 0;
        }
        if (Energy == 0)
        {
            ChekSup = 0;
            ChekEn = 0;
        }
        ChekOx = Oxygen;
        ChekWa = Water;
        ChekFo = Food;
        ChekEn = Energy;
    }
}
