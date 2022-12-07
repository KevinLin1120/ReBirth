using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class redDropAnim : MonoBehaviour
{
    public Animator anim;
    public GameObject blood; 
    // public Animator anim;
    
    void Start () {
        //anim = GetComponent<Animation> ();
        
    }

    public void OnTriggerEnter(Collider other) {
        if(other.tag == "money"){ //當播拿錢動畫==true
            print("money in"); 
            // anim.Play("redDrop");
            // anim.enabled = true;
            // anim.SetBool("redDrop",true);
            blood.SetActive(true);
        }
    }
}
