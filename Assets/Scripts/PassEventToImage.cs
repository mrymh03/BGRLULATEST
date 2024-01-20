using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PassEventToButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject button; // Assign the button GameObject in the inspector

    public void OnPointerEnter(PointerEventData eventData)
    {
        ExecuteEvents.Execute(button, eventData, ExecuteEvents.pointerEnterHandler);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ExecuteEvents.Execute(button, eventData, ExecuteEvents.pointerExitHandler);
    }
}

