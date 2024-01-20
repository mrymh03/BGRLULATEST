using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required for manipulating UI Text
using UnityEngine.SceneManagement; // Required for scene management

public class EndingTest : MonoBehaviour
{
    public int currentScore = TriviaGame.Score;
    public Text textBox;
    public GameObject highest;
    public GameObject medium;

    void Start()
    {
        // Initially hide the correct/incorrect panels
        //correctPanel.SetActive(false);
        //incorrectPanel.SetActive(false);
        //incorrectPanel2.SetActive(false);

        highest.SetActive(false);
        medium.SetActive(false);
        textBox.text = TriviaGame.Score.ToString();

        if(TriviaGame.Score > 4 && TriviaGame.Score<= 7)
        {
            medium.SetActive(true);
            highest.SetActive(false);
        }

        else if(TriviaGame.Score > 7)
        {
            highest.SetActive(true);
            medium.SetActive(false);
        }
    }
}


