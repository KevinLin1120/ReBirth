using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OVRTouchSample;

public class cardOpen : MonoBehaviour
{
    // public GameObject button;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;

    public UnityEvent press;
    GameObject presser;
    public bool isPressed = false;

    // public void OpenPanel(){
    //     if(Panel != null){
    //         Panel.SetActive(true);
    //     }
    // }

    void Start(){
        
    }
    void Update(){
        if(OVRInput.Get(OVRInput.Button.One)){
            Panel1.SetActive(true);
        }
        if(OVRInput.Get(OVRInput.Button.Two)){
            Panel2.SetActive(true);
        }
        if(OVRInput.Get(OVRInput.Button.Three)){
            Panel3.SetActive(true);
        }
        if(OVRInput.Get(OVRInput.Button.Four)){
            Panel4.SetActive(true);
        }
    }

    private void onTriggerEnter(Collider other){
        if(OVRInput.Get(OVRInput.Button.One)){
            Panel1.SetActive(true);
        }
        press.Invoke();
        isPressed = true;
            Debug.Log("Click!");
        if(!isPressed){
            presser = other.gameObject;
            press.Invoke();
            isPressed = true;
        }
        if(isPressed)
            Panel1.SetActive(true);
        // if(isPressed){
        //     Panel.SetActive(true);
        // }
    }

    public void cardShow(){
        if(isPressed)
            Panel1.SetActive(true);
    }

    private void OnMouseUpAsButton() {
        Debug.Log("OnMouseUpAsButton");
            Panel1.SetActive(true);
    }
}
