using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAlient : MonoBehaviour
{
    float elapsed = 0f;
    public GameObject Sup;
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 60f)
        {
            elapsed = 0f;

        }
    }
}