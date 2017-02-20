using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;
    int maxGuessesAllowed;

    public Text text;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = Random.RandomRange(min, max + 1);
        text.text = guess.ToString();
        //NextGuess();

        max = max + 1;

        maxGuessesAllowed = 10;

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    GuessHigher();
        //}
        //else if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    GuessLower();
        //}
        //else if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    GuessCorrect();
        //}
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessCorrect()
    {
        print("I won!");
        StartGame();
    }

    void NextGuess()
    {
        guess = Random.RandomRange(min,max+1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if(maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
        print("Higher or lower than " + guess);
        print("Up = higher, down = lower, return = equal");
    }

}
