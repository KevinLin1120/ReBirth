using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible=true;
        Cursor.lockState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isRight){        
            Debug.Log("pass");
        }
    }
}
