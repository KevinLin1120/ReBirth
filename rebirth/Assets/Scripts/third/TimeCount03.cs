using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount03 : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondLeft = 30;
    public bool timeGo = false;


    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondLeft;
    }
    void Update()
    {
        if (timeGo == false && secondLeft > 0)
        {
            StartCoroutine(TimeTake());
        }
    }

    IEnumerator TimeTake()
    {
        timeGo = true;
        yield return new WaitForSeconds(1);
        secondLeft -= 1;
        if (secondLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondLeft;
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + secondLeft;
        }
        timeGo = false;

    }
    public void addSeconds()
    {
        secondLeft += 5;
    }

}