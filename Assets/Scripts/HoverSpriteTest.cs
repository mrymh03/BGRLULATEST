using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    private Animator animator;
    private int PressOrNah = 0; 
    private int PressDown = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (PressDown != 1) {
        animator.SetBool("IsHover", true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        while (PressDown == 1) {
        animator.SetBool("IsHover", false);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (PressOrNah != 1) {
        animator.SetBool("IsPressed", true);
        PressDown = 1;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (PressOrNah != 1) {
        animator.SetBool("IsPressed", false);
        PressOrNah = 1;
        }
    }
}


