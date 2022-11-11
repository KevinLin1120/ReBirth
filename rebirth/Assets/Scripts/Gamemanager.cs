using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public bool isDeath = false;
    public screenFlash sf;

    // Start is called before the first frame update
    void Start()
    {
        //sf.GetComponent<screenFlash>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeath)
        {
            sf.flash();
            isDeath = !isDeath;
        }
    }
}
