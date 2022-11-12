using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redDropAnim : MonoBehaviour
{
    public Animation anim;
    // public Animator anim;
    
    void Start () {
        anim = GetComponent<Animation> ();
    }

    public void OnTriggerEnter(Collider other) {
        if(other.tag == "money"){
            print("money in"); 
            // anim.Play("redDrop");
            anim.Play();
            // anim.SetBool("redDrop",true);
        }
    }
}
