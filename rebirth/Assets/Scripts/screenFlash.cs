using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class screenFlash : MonoBehaviour
{
    //Screen flash 
    public GameObject screen;
    public float flashTime;
    private float lastTime;

    //public Transform blinkTop;
    //public Transform blinkBottom;
    //public Transform head;

    // Start is called before the first frame update
    void Start()
    {
        //screen = GetComponent<Image>();
        //Color c = screen.color;
        //c.a = 0;
        //screen.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void flash()
    {
        //StartCoroutine(startFlash(times));
        //StartCoroutine(startBlink(6));

        //startFlash(times);

        screen.SetActive(true);

    }
    //Start the screen flash 
    //IEnumerator startFlash(int times)
    //{
    //    Color c = screen.color;
    //    for(int t = 0; t < times; t++)
    //    {
    //        Debug.Log("Flash: " + t);

    //        //Keep the last time
    //        //lastTime = Time.time;

    //        // Flash red
    //        for(float i = 0; i < 0.56f; i+=0.02f)
    //        {
    //            //float nextTime = Time.time + 0.01f;
    //            //while(Time.time < nextTime){ Debug.Log("wait"); }
    //            c.a = i;
    //            screen.color = c;
    //            //await Task.Delay(10);
    //            //Invoke("", 0.01f);
    //            //Thread.Sleep(10);
    //            yield return new WaitForSeconds(0.01f);
    //        }
    //        //lastTime = Time.time;
    //        // Off flash
    //        for (float i = 0.56f; 0 < i; i-=0.02f)
    //        {
    //            //while ((Time.time - lastTime) < 0.01f) { }
    //            c.a = i;
    //            screen.color = c;
    //            //Thread.Sleep(10);
    //            //Invoke("", 0.01f);
    //            //await Task.Delay(10);
    //            yield return new WaitForSeconds(0.01f);
    //        }
    //        lastTime = Time.time;
    //        //while ((Time.time - lastTime) < 0.4f) { }
    //        //Thread.Sleep(400);
    //        //Invoke("", 0.4f);
    //        //await Task.Delay(400);
    //        yield return new WaitForSeconds(0.4f);
    //    }
    //}
    //IEnumerator startBlink(int times)
    ////async void startBlink(int times)
    //{
    //    Debug.Log("enter");
    //    for (int t = 0; t < times - 1; t++)
    //    {
    //        Debug.Log("blink: " + t);
    //        // Close eyes
    //        for (float i = 0; i < 0.125f; i += 0.005f)
    //        {
    //            blinkTop.position = blinkTop.position - new Vector3(0, i, 0);
    //            blinkBottom.position = blinkBottom.position + new Vector3(0, i, 0);
    //            yield return new WaitForSeconds(0.02f);
    //            //await Task.Delay(20);
    //            Debug.Log("top_close");
    //        }

    //        yield return new WaitForSeconds(0.3f);
    //        //await Task.Delay(30);
    //        // Open eyes
    //        for (float i = 0; i < 0.125f; i += 0.005f)
    //        {
    //            blinkTop.position = blinkTop.position + new Vector3(0, i, 0);
    //            blinkBottom.position = blinkBottom.position - new Vector3(0, i, 0);
    //            yield return new WaitForSeconds(0.02f);
    //            //await Task.Delay(20);
    //            Debug.Log("bottom_close");
    //        }
    //    }
    //    yield return new WaitForSeconds(0.3f);
    //    //await Task.Delay(30);

    //    // Close the eye
    //    for (float i = 0; i < 0.125f; i += 0.005f)
    //    {
    //        //head.rotation = Quaternion.Euler(0, 0, -i*10);
    //        blinkTop.position = blinkTop.position - new Vector3(0, i, 0);
    //        blinkBottom.position = blinkBottom.position + new Vector3(0, i, 0);
    //        yield return new WaitForSeconds(0.02f);
    //        //await Task.Delay(20);
    //    }
    //}
}
