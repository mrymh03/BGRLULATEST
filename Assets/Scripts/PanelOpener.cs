using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Pnl;
    private Animator animator;

    // If there is a panel, animate it as shown in the animator menu
     public void OpenPanel()
    {
        if (Pnl != null)
        {
            animator = Pnl.GetComponent<Animator>();

            if (animator != null)
            {
                bool isOpen = animator.GetBool("Open");
                animator.SetBool("Open", !isOpen);
            }
        }
    }

    public void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            animator = Pnl.GetComponent<Animator>();
            if (animator.GetBool("Open"))
            {
                OpenPanel();
            }
        }
    }
}
