using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathTrigger : MonoBehaviour
{
    public Gamemanager gm;
    // Start is called before the first frame update
    void Start()
    {
        //gm = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When the player hit the cube (is going to dead)
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "testcube":
                gm.isDeath = true;
                break;
        }
    }
}
