using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public bool isDeath = false;
    //public screenFlash sf;
    public GameObject sf;
    public blink blink;

    

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
                sf.SetActive(true);
                for (int i = 0; i < 6; i++)
                {
                    Debug.Log("enter" + i); 
                    yield return new WaitForSeconds(1.75f);
                }
                // Trun off the flash
                sf.SetActive(false);

                blink.blink_eye(true);
                for (int i = 0; i < 2; i++)
                {
                    Debug.Log("enter" + i);
                    yield return new WaitForSeconds(2.65f);
                }
                blink.blink_eye(false);

            }
            // Flash the player's screen
            //sf.flash(8);
            // Blink
            //blink.blink_eye(6);
            // Reborn
            //blink.openEye();
            isDeath = !isDeath;
        }
    }
}
