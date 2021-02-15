using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int maximumguess;
    [SerializeField] int minimumguess;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    int guessChecker;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        MakeGuess();
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        if (guess == maximumguess)
        {
            guessText.text = "I must have guessed it!";
        }
        else if (minimumguess != maximumguess && minimumguess < maximumguess)
        {
            minimumguess = guess + 1;
            MakeGuess();
        }
        else
        {
            guessText.text = "I must have guessed it!";
        }
    }

    public void OnPressLower()
    {
        if (guess == minimumguess)
        {
            guessText.text = "I must have guessed it!";
        }
        else if (minimumguess != maximumguess && minimumguess < maximumguess)
        {
            maximumguess = guess - 1;
            MakeGuess();
        }
        else
        {
            guessText.text = "I must have guessed it!";
        }
    }


    void MakeGuess()
    {
        guess = Random.Range(minimumguess, maximumguess);
        guessText.text = guess.ToString();
    }
}
