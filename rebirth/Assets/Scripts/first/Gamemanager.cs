using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject blackPanel, video, skipBtn, videoCanvas;
    public VideoPlayer vid;
    public bool isPlayEnd = false;

    public TimeCount tick;

    public GameObject bgm;

    public bool isDeath = false;
    public GameObject screenFlash;
    public blink blink;
    public passOut passOut;
    public reborn reborn;
    public Transform blink_top, blink_bottom;

    public GameObject blood;
    public bool isWin = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = 0;

        // Stop the countdown
        tick.enabled = false;

        vid.loopPointReached += playOver;
        // Delay 3s and indicate the btn
        StartCoroutine(playVideo());
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

            //IEnumerator death(){
            //    // Start the flash
            //    screenFlash.SetActive(true);
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Debug.Log("enter" + i); 
            //        yield return new WaitForSeconds(1.75f);
            //    }
            //    // Stop the flash
            //    screenFlash.SetActive(false);

            //    // Start blinking
            //    blink.blink_eye(true);
            //    // First time
            //    yield return new WaitForSeconds(2.65f);
            //    // Half of second time
            //    yield return new WaitForSeconds(1.2f);
            //    // Stop blinking
            //    blink.blink_eye(false);

            //    passOut.startPassOut(true);
            //    yield return new WaitForSeconds(5f);
            //    passOut.startPassOut(false);

            //    blink_top.localPosition = new Vector3(0, 1.5f, 0.459999114f);
            //    blink_bottom.localPosition = new Vector3(0, -1.5f, 0.459999114f);

            //    reborn.startReborn(true);
            //    yield return new WaitForSeconds(2f);
            //    reborn.startReborn(false);

            //}

            // Flash the player's screen
            //screenFlash.flash(8);
            // Blink
            //blink.blink_eye(6);
            // Reborn
            //blink.openEye();
        }
        if (isWin)
        {
            StartCoroutine(win());
            isWin =! isWin;
        }
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
        yield return new WaitForSeconds(1f);
        tick.secondLeft = 30;

        //yield return new WaitForSeconds(5f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator win()
    {
        blood.SetActive(true);
        // Wait for 2 seconds
        yield return new WaitForSeconds(5f);
        // Change to third scene
        SceneManager.LoadScene(1);
    }

    IEnumerator playVideo()
    {
        blackPanel.SetActive(true);
        // Delay 3s
        yield return new WaitForSeconds(1.5f);
        blackPanel.SetActive(false);
        video.SetActive(true);
        yield return new WaitForSeconds(3);
        skipBtn.SetActive(true);
    }

    void playOver(UnityEngine.Video.VideoPlayer vp)
    {
        video.SetActive(false);
        skipBtn.SetActive(false);
        videoCanvas.SetActive(false);
        bgm.SetActive(true);
        // Start to countdown
        tick.enabled = true;
    }
}
