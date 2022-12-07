using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardOpen : MonoBehaviour
{
    public GameObject Panel;

    // public void OpenPanel(){
    //     if(Panel != null){
    //         Panel.SetActive(true);
    //     }
    // }

    private void OnMouseUpAsButton() {
        Debug.Log("OnMouseUpAsButton");
            Panel.SetActive(true);
    }
}
