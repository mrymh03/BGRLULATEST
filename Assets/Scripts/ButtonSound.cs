using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // Required for event handlers

public class ButtonSound : MonoBehaviour, IPointerEnterHandler // Implement the interface
{
    public AudioSource audio; // Assign this in the inspector

    // This function is called when the cursor enters the button area
    public void OnPointerEnter(PointerEventData eventData)
    {
        audio.Play();
    }

    // You can keep your existing playButton method if it's used for other purposes
    public void playButton(){
        audio.Play();
    }
}
