using UnityEngine;
using System.Collections;

public class ResultAnimationController : MonoBehaviour
{
    public Animator correctAnimator;
    public Animator sorryAnimator;
    private static bool isDisplayed = false;

    public void DisplayResult(bool isCorrect)
    {
        if (!isDisplayed)
        {
            isDisplayed = true;
            if (isCorrect)
            {
                correctAnimator.SetTrigger("SlideIn");
            }
            else
            {
                sorryAnimator.SetTrigger("SlideIn");
            }
            StartCoroutine(HideResult());
        }
    }

    private IEnumerator HideResult()
    {
        yield return new WaitForSeconds(3); // Adjust as needed
        correctAnimator.SetTrigger("SlideOut"); // Assuming you have a SlideOut animation
        sorryAnimator.SetTrigger("SlideOut"); // Assuming you have a SlideOut animation
        isDisplayed = false;
    }
}
