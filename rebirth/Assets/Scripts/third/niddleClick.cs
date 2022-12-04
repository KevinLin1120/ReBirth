using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niddleClick : MonoBehaviour
{
    public GameObject niddle;
    public Animator anim;
    public GameObject blood2;

    public int i ;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
    private void OnMouseDown()
    {
        // Debug.Log("OnMouseUpAsButton");
        Debug.Log("OnMouseDown");
        // niddle.SetActive(false);
        // niddle.position = niddle.position + new Vector3(0, 10, 0);
        if (niddle.tag == "right")
        {
            // niddle.SetActive(false);
            // niddle.transform.position = niddle.transform.position += new Vector3(0, 10, 0);
            // anim.SetActive(false);

            //關閉浮起動畫
            anim.enabled = false;
            niddle.transform.Translate(new Vector3(0, 0.2f, 0));
            Debug.Log("right");
            i++;
            Debug.Log(i);
            if (i == 8){
                Debug.Log("done");
                niddle.SetActive(false);
                //blood anim
                blood2.SetActive(true);
            }
            // Debug.Log(i);
        }else if (niddle.tag == "wrong")
        {
            // niddle.SetActive(false);     
            // anim.SetActive(false);
            anim.enabled = false;
            niddle.transform.position = niddle.transform.position += new Vector3(0, 0.2f, 0);
            Debug.Log("wrong");
            i++;
            Debug.Log(i);
            if (i == 9){
                Debug.Log("done");
                niddle.SetActive(false);
            }
        }
        // i++;
        // Debug.Log(i);
        // if(i == 8){
        //     Debug.Log("done");
        // }
    }
}
