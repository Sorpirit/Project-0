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

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = container.localScale;
        scale.y = Mathf.Lerp(scale.y, isOpen ? 1 : 0, Time.deltaTime * i);
        container.localScale = scale;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (isOpen == true)
        {
            isOpen = false;
        }
        else
        {
            isOpen = true;
        }
    }
}
