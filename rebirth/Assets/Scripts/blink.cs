using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{
    public Transform blinkTop;
    public Transform blinkBottom;
    public Transform blinkObj;

    // Start is called before the first frame update
    void Start()
    {
        //blinkTop.position = new Vector3(0, 1, 0.46f);
        //blinkBottom.position = new Vector3(0, -1, 0.46f);
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
            }

            yield return new WaitForSeconds(0.3f);

            // Open eyes
            for (float i = 0; i < 0.125f; i += 0.005f)
            {
                blinkTop.position = blinkTop.position + new Vector3(0, i, 0);
                blinkBottom.position = blinkBottom.position - new Vector3(0, i, 0);
                yield return new WaitForSeconds(0.02f);
            }
        }
        yield return new WaitForSeconds(0.3f);

        // Close the eye
        for (float i = 0; i < 0.125f; i += 0.01f)
        {
            blinkTop.position = blinkTop.position - new Vector3(0, i, 0);
            blinkBottom.position = blinkBottom.position + new Vector3(0, i, 0);
            yield return new WaitForSeconds(0.02f);
        }
    }
}
