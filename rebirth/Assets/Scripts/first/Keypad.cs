using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{

    [SerializeField] private Text Ans;


    private string Answer = "1234";


    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void send()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "正確";
        }
        else
        {
            Ans.text = "錯誤";
        }
    }
}