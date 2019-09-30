using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Supplies : MonoBehaviour
{
    public GameObject DethUI;

    int AlientAmount;
    int AlientStorage;
    public int AlientStorageModule = 50;
    int AlientStorageModuleAmount;

    [SerializeField] private int oxCapacyti;
    [SerializeField] private int waCapacyti;
    [SerializeField] private int foCapacyti;
    [SerializeField] private int enCapacyti;

    public Storage OxStorageModule { get; private set; }
    public Storage WaStorageModule { get; private set; }
    public Storage FoStorageModule { get; private set; }
    public Storage EnStorageModule { get; private set; }
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

    private void Start()
    {
        OxStorageModule = new Storage(oxCapacyti, true);
        WaStorageModule = new Storage(waCapacyti, true);
        FoStorageModule = new Storage(foCapacyti, true);
        EnStorageModule = new Storage(enCapacyti, true);

        SetText();
    }

    private void SetText()
    {
        OxygenText.text = "Oxygen: " + OxStorageModule.StroageVal + " l ";
        WaterText.text = "Water: " + WaStorageModule.StroageVal + " l ";
        FoodText.text = "Food: " + FoStorageModule.StroageVal + " kg ";
        EnergyText.text = "Energy: " + EnStorageModule.StroageVal + " A/h";
    }

}