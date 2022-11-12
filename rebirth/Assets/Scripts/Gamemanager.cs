using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public bool isDeath = false;
    public screenFlash sf;
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
            // Flash the player's screen
            sf.flash(8);
            // Blink
            blink.blink_eye(5);
            isDeath = !isDeath;
        }
    }
}
