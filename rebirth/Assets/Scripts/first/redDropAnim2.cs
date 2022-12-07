using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class redDropAnim2 : MonoBehaviour
{
    public Animator anim;
    public GameObject blood2; 
    // public Animator anim;
    
    void Start () {
        //anim = GetComponent<Animation> ();
        
    }

    public void OnTriggerEnter(Collider other) {
        if(other.tag == "money"){ 
            // anim.Play("redDrop");
            // anim.enabled = true;
            // anim.SetBool("redDrop",true);
            blood2.SetActive(true);
        }
    }
}
