using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public bool isDeath = false;
    public GameObject screenFlash;
    public blink blink;
    public passOut passOut;
    public reborn reborn;
    public Transform blink_top, blink_bottom;

    public GameObject blood;

    public TimeCount03 tick;

    public bool isWin = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible=true;
        Cursor.lockState = 0;

        Cursor.visible = true;
        Cursor.lockState = 0;

        // Reset the time
        //tick.secondLeft = 30;
        // Stop the countdown
        tick.enabled = true;

        //vid.loopPointReached += playOver;
        // Delay 3s and indicate the btn
        //StartCoroutine(playVideo());
    }

    // Update is called once per frame
    void Update()
    {
        isDeath = (tick.secondLeft == 5) ? true : false;
        // If player is going to dead
        if (isDeath)
        {
            StartCoroutine(death());
            isDeath = !isDeath;
        }
        if (isWin)
        {
            StartCoroutine(win());
            isWin = !isWin;
        }
    }

    public void rightNiddle()
    {
        tick.addSeconds();
    }

    IEnumerator death()
    {
        // Start the flash
        screenFlash.SetActive(true);
        for (int i = 0; i < 6; i++)
        {
            Debug.Log("enter" + i);
            yield return new WaitForSeconds(1.75f);
        }
        // Stop the flash
        screenFlash.SetActive(false);

        // Start blinking
        blink.blink_eye(true);
        // First time
        yield return new WaitForSeconds(2.65f);
        // Half of second time
        yield return new WaitForSeconds(1.2f);
        // Stop blinking
        blink.blink_eye(false);

        passOut.startPassOut(true);
        yield return new WaitForSeconds(4.5f);
        passOut.startPassOut(false);

        yield return new WaitForSeconds(0.5f);
        blink_top.localPosition = new Vector3(0, 1.5f, 0.459999114f);
        blink_bottom.localPosition = new Vector3(0, -1.5f, 0.459999114f);

        reborn.startReborn(true);
        yield return new WaitForSeconds(2f);
        reborn.startReborn(false);

        // Restart the countdown
        //yield return new WaitForSeconds(1f);
        //tick.secondLeft = 30;

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }

    IEnumerator win()
    {
        // Stop the countdown
        tick.enabled = false;

        blood.SetActive(true);
        // Wait for 2 seconds
        yield return new WaitForSeconds(5f);
        // Change to third scene
        //SceneManager.LoadScene(1);
    }
}
