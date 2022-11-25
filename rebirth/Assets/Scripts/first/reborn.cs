using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reborn : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        // Get the animator, which is attachded to the gameobject
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startReborn(bool enableStatus)
    {
        anim.enabled = enableStatus;
    }
}
