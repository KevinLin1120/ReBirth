using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenFlash : MonoBehaviour
{
    //Screen flash 
    public Image screen;
    public float flashTime;

    // Start is called before the first frame update
    void Start()
    {
        screen = GetComponent<Image>();
        Color c = screen.color;
        c.a = 0;
        screen.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void flash()
    {
        Debug.Log("flash");
        StartCoroutine(startFlash());
    }
    IEnumerator startFlash()
    {
        Color c = screen.color;
        for(int times = 0; times < 10; times++)
        {
            for(float i = 0; i < 0.56f; i+=0.02f)
            {
                yield return new WaitForSeconds(0.01f);
                c.a = i;
                screen.color = c;
            }
            for (float i = 0.56f; 0 < i; i -= 0.02f)
            {
                yield return new WaitForSeconds(0.01f);
                c.a = i;
                screen.color = c;
            }
            yield return new WaitForSeconds(0.4f);
        }
    }
}
