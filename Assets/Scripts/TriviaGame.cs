using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriviaGame : MonoBehaviour
{

    public static int Score { get; private set; }
    public Button optionA;
    public Button optionB;
    public Button optionC;
    public GameObject correctPanel; // Set this to the panel that says "Correct!"
    public GameObject incorrectPanel; // Set this to the panel that says "Incorrect!"
    public GameObject incorrectPanel2;
    public GameObject correct;
    public GameObject incorrect;
    public GameObject next;
    public GameObject nextButton;


    void Start()
    {
        // Initially hide the correct/incorrect panels
        correctPanel.SetActive(false);
        incorrectPanel.SetActive(false);
        incorrectPanel2.SetActive(false);
        ResetForNewQuestion();
        correct.SetActive(false);
        incorrect.SetActive(false);
        next.SetActive(false);
        nextButton.SetActive(false);

        // Add listeners for button clicks
        optionA.onClick.AddListener(() => CheckAnswer('A'));
        optionB.onClick.AddListener(() => CheckAnswer('B'));
        optionC.onClick.AddListener(() => CheckAnswer('C'));

        Debug.Log("Current Score: " + Score);
    }

    void CheckAnswer(char option)
    {
        // Hide both panels before showing the correct one
        correctPanel.SetActive(false);
        incorrectPanel.SetActive(false);
        incorrectPanel2.SetActive(false);
        correct.SetActive(false);
        incorrect.SetActive(false);
        next.SetActive(false);
        nextButton.SetActive(false);

        if (option == 'B') // The correct answer
        {
            // Show the correct panel
            correctPanel.SetActive(true);
            //GameManager.Instance.AddScore(1);
            Score += 1;
            correct.SetActive(true);
            next.SetActive(true);
            nextButton.SetActive(true);
        }
        else if(option == 'C') // Incorrect answer
        {
            // Show the incorrect panel
            incorrectPanel2.SetActive(true);
            incorrect.SetActive(true);
            correctPanel.SetActive(true);
            next.SetActive(true);
            nextButton.SetActive(true);
        }
        else if(option == 'A'){
            incorrectPanel.SetActive(true);
            incorrect.SetActive(true);
            correctPanel.SetActive(true);
            next.SetActive(true);
            nextButton.SetActive(true);
        }
    }

    public void ResetForNewQuestion()
    {
    correct.SetActive(false);
    incorrect.SetActive(false);
    next.SetActive(false);
    nextButton.SetActive(false);
    // Add any additional reset logic here
    }

    

}
