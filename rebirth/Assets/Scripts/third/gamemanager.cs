using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible=true;
        Cursor.lockState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkClicks(){
        Debug.Log("checkClicks");
    }
}
