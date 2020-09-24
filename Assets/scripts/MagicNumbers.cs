using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    public Text title;

    public int max = 1000;
    public int min = 1;
    int guess;

    void Start()
    {
        title.text = "MagicNumbers";
        title.color = Color.black;
        print("Пожалуйста, загадайте число от " + min + " до " + max);
        UpdateGuess();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("Мои поздравления....");
        }

    }

    void UpdateGuess()
    {
        guess = (min + max) / 2;
        print("А Ваше число случаем не " + guess);
    }
}
