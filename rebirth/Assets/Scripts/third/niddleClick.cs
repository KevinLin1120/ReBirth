using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niddleClick : MonoBehaviour
{
    public GameObject niddle, niddle2, niddle3;
    public GameObject niddleCanvas, niddleCanvas2, niddleCanvas3;
    public Animator anim;
    public GameObject blood2;
    public gamemanager GM;

    public int i;
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
        Debug.Log("OnMouseDown");
        if (niddle.tag == "right")
        {
            //關閉浮起動畫
            anim.enabled = false;
            niddle.transform.position = niddle.transform.position += new Vector3(0, 0.2f, 0);
            Debug.Log("right");
            i++;
            Debug.Log(i);
            if (i == 8)
            {
                Debug.Log("done");
                niddleCanvas.SetActive(false);
                niddle.SetActive(false);
                //blood anim
                blood2.SetActive(true);
                //GM.isRight = true;
                
            }
            // Debug.Log(i);
        }
        else if (niddle.tag == "wrong")
        {
            // niddle.SetActive(false);     
            // anim.SetActive(false);
            anim.enabled = false;
            niddle.transform.position = niddle.transform.position += new Vector3(0, 0.2f, 0);
            Debug.Log("wrong");
            i++;
            Debug.Log(i);
            if (i == 8)
            {
                Debug.Log("done");
                niddle.SetActive(false);
                // GM.isRight = false;
                // niddleCanvas.SetActive(false);
                MirrorFlipCamera(Camera.main);
                // niddleCanvas2.SetActive(true);
            }
        }
        // i++;
        // Debug.Log(i);
        // if(i == 8){
        //     Debug.Log("done");
        // }
    }

    private void MirrorFlipCamera(Camera camera)
    {



        Matrix4x4 mat = camera.projectionMatrix;



        mat *= Matrix4x4.Scale(new Vector3(-1, 1, 1));



        camera.projectionMatrix = mat;



    }
}
