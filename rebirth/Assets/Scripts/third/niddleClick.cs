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
    private void OnMouseDown() {
        // Debug.Log("OnMouseUpAsButton");
        Debug.Log("OnMouseDown");
        // niddle.SetActive(false);
        // niddle.position = niddle.position + new Vector3(0, 10, 0);
        if(niddle.tag == "right"){
            // niddle.SetActive(false);
            niddle.transform.position = niddle.transform.position += new Vector3(0, 10, 0);
            Debug.Log("right");
        }else if(niddle.tag == "wrong"){
            // niddle.SetActive(false);     
            niddle.transform.position = niddle.transform.position += new Vector3(0, 10, 0);
            Debug.Log("wrong");            
        }
    }

    
}
