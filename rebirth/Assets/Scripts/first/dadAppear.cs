using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadAppear : MonoBehaviour
{
    public GameObject dad;
    public Animator dadWalk;

    // public void OpenPanel(){
    //     if(Panel != null){
    //         Panel.SetActive(true);
    //     }
    // }

    private void OnMouseUpAsButton() {
        Debug.Log("OnMouseUpAsButton");
        if(dad != null){    
            dad.SetActive(true);
            dadWalk.enabled = true;
        }
    }
}
