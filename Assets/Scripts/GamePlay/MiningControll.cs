using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningControll : MonoBehaviour
{
    public KeyCode mineButton;

    private int layerMasks;

    private void Start()
    {
        layerMasks = ~(1 << LayerMask.NameToLayer("Player"));
        //layerMasks = ~layerMasks;
    }

    private void Update()
    {
        if (Input.GetKeyDown(mineButton)) Mine();
    }

    private void Mine()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, Mathf.Infinity, layerMasks);

        if (hitInfo)
        {
            
            Debug.Log(hitInfo.transform.name);
        }
    }
}
