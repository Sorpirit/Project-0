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

    public float laserDamage;
    [Range(0f,1f)][SerializeField]private float nonFocusDecrising;
    public float damageRate;
    private float damageTimer;
 
    private float focusPointOfset;
    [SerializeField] private float focusMinDistanc;

    private bool isHited;

    private void Start()
    {
        layerMasks = ~(1 << LayerMask.NameToLayer("Player"));// Ignore Player mask
        //layerMasks = ~layerMasks;
    }

    private void Update()
    {
        if (Input.GetKey(mineButton))
        {
            focusPointOfset = Input.GetAxis(mineAxis);

            focusPoint.position += transform.up * focusPointOfset;

            Mine();
        }
        else if(Input.GetKeyUp(mineButton))
        {
            
            for (int i = 0; i < Mathf.Min(minigLines.Length, startPoints.Length); i++)
            {
                minigLines[i].SetPosition(0, Vector2.zero);
                minigLines[i].SetPosition(1, Vector2.zero);
            }
        }


        if(damageTimer < damageRate)damageTimer += Time.deltaTime;
    }

    private void Mine()
    {
        
        for(int i =0; i < Mathf.Min(minigLines.Length,startPoints.Length); i++)
        {
            chekHit(i);
        }
        if (isHited)
        {
            damageTimer = 0;
            isHited = false;
        }
    }

    private void chekHit(int index)
    {
        Vector2 dir = (focusPoint.position - startPoints[index].position).normalized;
        RaycastHit2D hitInfo = Physics2D.Raycast(startPoints[index].position, dir, maxMagnitude, layerMasks);

        if (hitInfo)
        {
            AsteroidControll asteroid = hitInfo.transform.GetComponent<AsteroidControll>();
            if (asteroid != null && damageTimer >= damageRate)
            {

                if(Vector2.Distance(hitInfo.point,focusPoint.position) <= focusMinDistanc)
                {
                    //Krit
                    asteroid.Hit(laserDamage);
                    minigLines[index].endColor = Color.red;
                }
                else
                {
                    //Non focus hit
                    asteroid.Hit(laserDamage * (1 - nonFocusDecrising));
                    minigLines[index].endColor = Color.white;
                }

                isHited = true;
                
            }

            minigLines[index].SetPosition(0, startPoints[index].position);
            minigLines[index].SetPosition(1, hitInfo.point);
        }
        else
        {
            minigLines[index].SetPosition(0, startPoints[index].position);
            minigLines[index].SetPosition(1, dir * 10 + (Vector2) transform.position);
        }

    }

    private void HitAsteroid()
    {

    }

}
