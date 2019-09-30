using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dropdown : MonoBehaviour, IPointerClickHandler
{
    public RectTransform container;
    public bool isOpen;
    public int i;

    void Start()
    {
        container = transform.Find("Container").GetComponent<RectTransform>();
        isOpen = false;
    }

    void Update()
    {
        Vector3 scale = container.localScale;
        //Do you know what dose [isOpen ? 1 : 0] mean?
        scale.y = Mathf.Lerp(scale.y, isOpen ? 1 : 0, Time.deltaTime * i);
        container.localScale = scale;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Bed way to implement tugle button
        /*if (isOpen == true)
        {
            isOpen = false;
        }
        else
        {
            isOpen = true;
        }*/
        // Better way:
        isOpen = !isOpen;
    }
}
