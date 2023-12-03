using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Pnl;
    [SerializeField] private Animator animator;

    /// <summary>
    /// If there is a panel, animate it as shown in the animator menu
    /// </summary>
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

    /// <summary>
    /// Escape running update
    /// </summary>
    public void Update()
    {        
         Escape();
    }

    /// <summary>
    /// checks to see if escape key has been hit while the playlist panel is open so that it can close the panel.
    /// Code moved here from Update()
    /// </summary>
    private void Escape()
    {
        if (Input.GetButtonDown("Cancel") && Pnl.name == "PlaylistPanel")
        {
            animator = Pnl.GetComponent<Animator>();
            if (animator.GetBool("Open"))
            {
                OpenPanel();
            }
        }
    }



}
