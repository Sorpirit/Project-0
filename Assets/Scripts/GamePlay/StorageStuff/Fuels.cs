using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuels : MonoBehaviour
{

    [SerializeField] private int hyCapacyti;
    [SerializeField] private int elCapacyti;
    [SerializeField] private int nuCapacyti;
    [SerializeField] private int warCapacyti;

    public Storage HyStorageModule { get; private set; }
    public Storage ElStorageModule { get; private set; }
    public Storage NuStorageModule { get; private set; }
    public Storage WarStorageModule { get; private set; }

    public Text HydrogenText;
    public Text ElectricText;
    public Text NuclearText;
    public Text WarpText;

    private void Start()
    {
        HyStorageModule = new Storage(hyCapacyti, true);
        ElStorageModule = new Storage(elCapacyti, true);
        NuStorageModule = new Storage(nuCapacyti, true);
        WarStorageModule = new Storage(warCapacyti, true);

        SetText();
    }

    private void SetText()
    {
        HydrogenText.text = "Hydrogen: " + HyStorageModule.StroageVal + " kg ";
        ElectricText.text = "Electric: " + ElStorageModule.StroageVal + " W ";
        NuclearText.text = "Nuclear: " + NuStorageModule.StroageVal + " kg ";
        WarpText.text = "Warp: " + WarStorageModule.StroageVal + " ?/?";
    }


}