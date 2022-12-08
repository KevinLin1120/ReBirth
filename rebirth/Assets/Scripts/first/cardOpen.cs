using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;

public class cardOpen : MonoBehaviour
{
    public GameObject button;
    public GameObject Panel;

    // public void OpenPanel(){
    //     if(Panel != null){
    //         Panel.SetActive(true);
    //     }
    // }

    void Start(){
        
    }
    void Update(){
        if(OVRInput.Get(OVRInput.Button.One)){
            Panel.SetActive(true);
        }
    }

    private void OnMouseUpAsButton() {
        Debug.Log("OnMouseUpAsButton");
            Panel.SetActive(true);
    }
}
