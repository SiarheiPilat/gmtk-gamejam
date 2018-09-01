using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IDragHandler, IEndDragHandler
{

    private Vector3 sittingPosition;

    void Start()
    {
        sittingPosition = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = sittingPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
