using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; // Required for the Button component
using System.Collections;

public class AnswerButton : MonoBehaviour, IPointerClickHandler
{
    public GameObject correctButton; // Assign the correct button in the inspector
    private Animator animator;
    private Button button; // Reference to the Button component
    private static bool isAnswered = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        button = GetComponent<Button>(); // Get the Button component
        isAnswered = false;
    }

    public void OnPointerClick(PointerEventData eventData)
{
    if (!isAnswered)
    {
        // Trigger the animations
        if (gameObject == correctButton)
        {
            animator.SetBool("IsCorrect", true);
        }
        else
        {
            animator.SetBool("IsWrong", true);

            Animator correctAnimator = correctButton.GetComponent<Animator>();
            if (correctAnimator != null)
            {
                correctAnimator.SetBool("IsCorrect", true);
            }
        }

        StartCoroutine(DisableButtonTemporarily(button));
        StartCoroutine(DisableButtonsAfterAnimation());
        isAnswered = true;
    }
}

private IEnumerator DisableButtonTemporarily(Button buttonToDisable)
{
    // Optional: Wait for a very short time (like 0.1 seconds)
    yield return new WaitForSeconds(0.0f);

    if (buttonToDisable != null)
    {
        buttonToDisable.interactable = false;
    }
}


    private IEnumerator DisableButtonsAfterAnimation()
{
    // Wait for a duration equal to the longest animation's length
    yield return new WaitForSeconds(0.0f); // Adjust this time as needed

    // Disable the button component on all buttons
    AnswerButton[] allButtons = FindObjectsOfType<AnswerButton>();
    foreach (var btn in allButtons)
    {
        if (btn.button != null)
        {
            btn.button.interactable = false;
        }
    }
}


}
