using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Materials : MonoBehaviour
{
	int Material0;
	int Material1;
	int Material2;
	int Material3;
	int Material0Storage;
	int Material1Storage;
	int Material2Storage;
	int Material3Storage;
	public int Material0StorageModule = 50;
	public int Material1StorageModule = 50;
	public int Material2StorageModule = 50;
	public int Material3StorageModule = 50;
	int Material0StorageModuleAmount;
	int Material1StorageModuleAmount;
	int Material2StorageModuleAmount;
	int Material3StorageModuleAmount;
	GameObject[] M0StorageModule;
	GameObject[] M1StorageModule;
	GameObject[] M2StorageModule;
	GameObject[] M3StorageModule;
	public Text Material0Text;
	public Text Material1Text;
	public Text Material2Text;
	public Text Material3Text;

	void Update()
	{
		//Finding Material0 Storage Modules and Making sure that there isnt more Material0 then the storage you have for it
		M0StorageModule = GameObject.FindGameObjectsWithTag("Material0StorageModule");
		Material0StorageModuleAmount = 0;
		foreach (GameObject O in M0StorageModule)
		{
			Material0StorageModuleAmount += 1;
		}
		Material0Storage = Material0StorageModule * Material0StorageModuleAmount;
		if (Material0 >= Material0Storage)
		{
			Material0 = Material0Storage;
		}
		if (Material0 <= 0)
		{
			Material0 = 0;
		}
		Material0Text.text = "Material0: " + Material0;
		//Finding Material1 Storage Modules and Making sure that there isnt more Material1 then the storage you have for it
		M1StorageModule = GameObject.FindGameObjectsWithTag("Material1StorageModule");
		Material1StorageModuleAmount = 0;
		foreach (GameObject D in M1StorageModule)
		{
			Material1StorageModuleAmount += 1;
		}
		Material1Storage = Material1StorageModule * Material1StorageModuleAmount;
		if (Material1 >= Material1Storage)
		{
			Material1 = Material1Storage;
		}
		if (Material1 <= 0)
		{
			Material1 = 0;
		}
		Material1Text.text = "Material1: " + Material1;
		//Finding Material2 Storage Modules and Making sure that there isnt more Water then the Material2 you have for it
		M2StorageModule = GameObject.FindGameObjectsWithTag("Material2StorageModule");
		Material2StorageModuleAmount = 0;
		foreach (GameObject E in M2StorageModule)
		{
			Material2StorageModuleAmount += 1;
		}
		Material2Storage = Material2StorageModule * Material2StorageModuleAmount;
		if (Material2 >= Material2Storage)
		{
			Material2 = Material2Storage;
		}
		if (Material2 <= 0)
		{
			Material2 = 0;
		}
		Material2Text.text = "Material2: " + Material2;
		//Finding Material3 Storage Modules and Making sure that there isnt more Energy then the Material3 you have for it
		M3StorageModule = GameObject.FindGameObjectsWithTag("Material3StorageModule");
		Material3StorageModuleAmount = 0;
		foreach (GameObject F in M3StorageModule)
		{
			Material3StorageModuleAmount += 1;
		}
		Material3Storage = Material3StorageModule * Material3StorageModuleAmount;
		if (Material3 >= Material3Storage)
		{
			Material3 = Material3Storage;
		}
		if (Material3 <= 0)
		{
			Material3 = 0;
		}
		Material3Text.text = "Material3: " + Material3;
	}
    public void AddMaterial0()
    {
        Material0 += 1;
    }
}