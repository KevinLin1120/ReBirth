using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{
    public Transform blinkTop;
    public Transform blinkBottom;
    public Transform head;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void blink_eye(int times)
    {
        StartCoroutine(startBlink(times));
    }
    IEnumerator startBlink(int times)
    {
        for(int t = 0; t < times -1; t++)
        {
            Debug.Log("blink: " + t);
            // Close eyes
            for(float i = 0; i < 0.125f; i += 0.005f)
            {
                blinkTop.position = blinkTop.position - new Vector3(0, i, 0);
                blinkBottom.position = blinkBottom.position + new Vector3(0, i, 0);
                yield return new WaitForSeconds(0.02f);
                Debug.Log("top_close");
            }

            yield return new WaitForSeconds(0.3f);

            // Open eyes
            for (float i = 0; i < 0.125f; i += 0.005f)
            {
                blinkTop.position = blinkTop.position + new Vector3(0, i, 0);
                blinkBottom.position = blinkBottom.position - new Vector3(0, i, 0);
                yield return new WaitForSeconds(0.02f);
                Debug.Log("bottom_close");
            }
        }
        yield return new WaitForSeconds(0.3f);

        // Close the eye
        for (float i = 0; i < 0.125f; i += 0.005f)
        {
            //head.rotation = Quaternion.Euler(0, 0, -i*10);
            blinkTop.position = blinkTop.position - new Vector3(0, i, 0);
            blinkBottom.position = blinkBottom.position + new Vector3(0, i, 0);
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void openEye()
    {
        StartCoroutine(startOpenEye());
    }
    IEnumerator startOpenEye()
    {
        // Open the eye
        for (float i = 0; i < 0.125f; i += 0.005f)
        {
            blinkTop.position = blinkTop.position + new Vector3(0, i, 0);
            blinkBottom.position = blinkBottom.position - new Vector3(0, i, 0);
            yield return new WaitForSeconds(0.02f);
        }
    }
}
