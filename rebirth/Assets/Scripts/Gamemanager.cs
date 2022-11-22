using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public bool isDeath = false;
    public GameObject screenFlash;
    public blink blink;
    public passOut passOut;
    public reborn reborn;
    public Transform blink_top, blink_bottom;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If player is going to dead
        if (isDeath)
        {
            StartCoroutine(death());
            IEnumerator death(){
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
                yield return new WaitForSeconds(5f);
                passOut.startPassOut(false);

                blink_top.localPosition = new Vector3(0, 1.5f, 0.459999114f);
                blink_bottom.localPosition = new Vector3(0, -1.5f, 0.459999114f);

                reborn.startReborn(true);
                yield return new WaitForSeconds(2f);
                reborn.startReborn(false);

            }
            // Flash the player's screen
            //screenFlash.flash(8);
            // Blink
            //blink.blink_eye(6);
            // Reborn
            //blink.openEye();
            isDeath = !isDeath;
            
        }
    }
}
