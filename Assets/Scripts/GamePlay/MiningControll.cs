using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningControll : MonoBehaviour
{
    public KeyCode mineButton;
    public string mineAxis;

    private int layerMasks;

    [SerializeField] private LineRenderer[] minigLines;
    [SerializeField] private Transform[] startPoints;
    [SerializeField] private Transform focusPoint;

    public float maxMagnitude; 
 
    private float focusPointOfset;

    public float mouseWheleSensivyty;

    private void Start()
    {
        layerMasks = ~(1 << LayerMask.NameToLayer("Player"));// Ignore Player mask
        //layerMasks = ~layerMasks;
    }

    private void Update()
    {
        if (Input.GetKey(mineButton)) Mine();

        focusPointOfset += Input.mouseScrollDelta.y * mouseWheleSensivyty;
    }

    private void Mine()
    {
        
        for(int i =0; i < Mathf.Min(minigLines.Length,startPoints.Length); i++)
        {
            chekHit(i);
        }
        
    }

    private void chekHit(int index)
    {
        Vector2 dir = ((focusPoint.position + transform.up * focusPointOfset) - startPoints[index].position).normalized;
        RaycastHit2D hitInfo = Physics2D.Raycast(startPoints[index].position, dir, maxMagnitude, layerMasks);

        if (hitInfo)
        {
            minigLines[index].SetPosition(0, startPoints[index].position);
            minigLines[index].SetPosition(1, hitInfo.point);
        }
        else
        {
            minigLines[index].SetPosition(0, startPoints[index].position);
            minigLines[index].SetPosition(1, dir * 10 + (Vector2) transform.position);
        }

    }

}
