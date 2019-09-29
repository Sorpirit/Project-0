﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuels : MonoBehaviour
{
    int Hydrogen;
    int Electric;
    int Nuclear;
    int Warp;

    public int ChekFuel;
    public int ChekHy;
    public int ChekEl;
    public int ChekNu;
    public int ChekWar;

    public int HydrogenStorage;
    public int ElectricStorage;
    public int NuclearStorage;
    public int WarpStorage;

    public int HydrogenStorageModule = 50;
    public int ElectricStorageModule = 50;
    public int NuclearStorageModule = 50;
    public int WarpStorageModule = 50;

    int HydrogenStorageModuleAmount;
    int ElectricStorageModuleAmount;
    int NuclearStorageModuleAmount;
    int WarpStorageModuleAmount;

    GameObject[] HyStorageModule;
    GameObject[] ElStorageModule;
    GameObject[] NuStorageModule;
    GameObject[] WarStorageModule;

    public Text HydrogenText;
    public Text ElectricText;
    public Text NuclearText;
    public Text WarpText;

    void Update()
    {
        //Finding hydrogen Storage Modules and Making sure that there isnt more Hydrogen then the storage you have for it
        HyStorageModule = GameObject.FindGameObjectsWithTag("HydrogenStorageModule");
        HydrogenStorageModuleAmount = 0;
        foreach (GameObject O in HyStorageModule)
        {
            HydrogenStorageModuleAmount += 1;
        }
        HydrogenStorage = HydrogenStorageModule * HydrogenStorageModuleAmount;
        if (Hydrogen >= HydrogenStorage)
        {
            Hydrogen = HydrogenStorage;
        }
        if (Hydrogen <= 0)
        {
            Hydrogen = 0;
        }
        HydrogenText.text = "Hydrogen: " + Hydrogen;
        //Finding batery Storage Modules and Making sure that there isnt more Electricity then the storage you have for it
        ElStorageModule = GameObject.FindGameObjectsWithTag("ElectricStorageModule");
        ElectricStorageModuleAmount = 0;
        foreach (GameObject D in ElStorageModule)
        {
            ElectricStorageModuleAmount += 1;
        }
        ElectricStorage = ElectricStorageModule * ElectricStorageModuleAmount;
        if (Electric >= ElectricStorage)
        {
            Electric = ElectricStorage;
        }
        if (Electric <= 0)
        {
            Electric = 0;
        }
        ElectricText.text = "Electricity: " + Electric;
        //Finding Nuclear Storage Modules and Making sure that there isnt more Water then the Nuclear you have for it
        NuStorageModule = GameObject.FindGameObjectsWithTag("NuclearStorageModule");
        NuclearStorageModuleAmount = 0;
        foreach (GameObject E in NuStorageModule)
        {
            NuclearStorageModuleAmount += 1;
        }
        NuclearStorage = NuclearStorageModule * NuclearStorageModuleAmount;
        if (Nuclear >= NuclearStorage)
        {
            Nuclear = NuclearStorage;
        }
        if (Nuclear <= 0)
        {
            Nuclear = 0;
        }
        NuclearText.text = "Nuclear: " + Nuclear;
        //Finding Warp Storage Modules and Making sure that there isnt more Energy then the Warp you have for it
        WarStorageModule = GameObject.FindGameObjectsWithTag("WarpStorageModule");
        WarpStorageModuleAmount = 0;
        foreach (GameObject F in WarStorageModule)
        {
            WarpStorageModuleAmount += 1;
        }
        WarpStorage = WarpStorageModule * WarpStorageModuleAmount;
        if (Warp >= WarpStorage)
        {
            Warp = WarpStorage;
        }
        if (Warp <= 0)
        {
            Warp = 0;
        }
        WarpText.text = "Warp: " + Warp;
        ChekingFuel();
    }
    public void AddHydrogen()
    {
        Hydrogen += 1;
    }
    public void AddElectric()
    {
        Electric += 1;
    }
    public void AddNuclear()
    {
        Nuclear += 1;
    }
    public void AddWarp()
    {
        Warp += 1;
    }
    public void TakeHydrogen()
    {
        if(Hydrogen >= 1)
        {
            Hydrogen -= 1;
        }
    }
    public void TakeElectric()
    {
        if (Electric >= 1)
        {
            Electric -= 1;
        }
    }
    public void TakeNuclear()
    {
        if (Nuclear >= 1)
        {
            Nuclear -= 1;
        }
    }
    public void TakeWarp()
    {
        if (Warp >= 1)
        {
            Warp -= 1;
        }
    }
    public void ChekingFuel()
    {
        if (Hydrogen == 0)
        {
            ChekFuel = 0;
            ChekHy = 0;
        }
        if (Electric == 0)
        {
            ChekFuel = 0;
            ChekEl = 0;
        }
        if (Nuclear == 0)
        {
            ChekFuel = 0;
            ChekNu = 0;
        }
        if (Warp == 0)
        {
            ChekFuel = 0;
            ChekWar = 0;
        }
        ChekHy = Hydrogen;
        ChekEl = Electric;
        ChekNu = Nuclear;
        ChekWar = Warp;
    }
}