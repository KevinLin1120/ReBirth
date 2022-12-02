using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niddleClick : MonoBehaviour
{
    public GameObject niddle;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    private void OnMouseDown(Collider other) {
        Debug.Log("OnMouseUpAsButton");
        niddle.SetActive(false);
        // if(niddle.tag == "right"){
        //     niddle.SetActive(false);
        //     Debug.Log("right");
        // }else if(niddle.tag == "wrong"){
        //     niddle.SetActive(false);
        //     Debug.Log("wrong");            
        // }
    }
}
