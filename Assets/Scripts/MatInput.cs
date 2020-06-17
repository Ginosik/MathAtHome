using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatInput : MonoBehaviour
{

    private int number1, number2, result;
    public Text firstTerm, secondTerm, sign, input;
    private string message;
    bool enter = false;

    void Start()
    {
        number1 = (int)Random.Range(1.0f, 100.0f);
        firstTerm.text = number1.ToString();
        number2 = (int)Random.Range(1.0f, 100.0f);
        secondTerm.text = number2.ToString();
        result = number1 + number2;
        input.text = input.GetComponent<Text>().text;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            enter = true;
        }
        
        if (enter)
        {
            if (int.Parse(input.text) == result)
            {
                message = "Correct";
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                message = "Wrong";
            }
            enter = false;
            Debug.Log(message);
        }
    }

    public void Enter()
    {
        enter = true;
    }

}
