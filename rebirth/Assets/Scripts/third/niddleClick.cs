using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niddleClick : MonoBehaviour
{
    public GameObject niddle1;
    // public GameObject niddle2;
    public GameObject niddleCanvas, niddleCanvas2;
    public Animator anim;
    // public GameObject blood2;
    public gamemanager GM;
    public AudioClip horrible;
    public AudioSource horribleAudio;
    public AudioClip click;
    public AudioSource clickAudio;

    public int i;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        clickAudio.PlayOneShot(click);
        if (niddle1.tag == "right")
        {
            //關閉浮起動畫
            anim.enabled = false;
            niddle1.transform.position = niddle1.transform.position += new Vector3(0, 0.2f, 0);
            Debug.Log("right");
            i++;
            Debug.Log(i);
            if (i == 8)
            {
                Debug.Log("done");
                niddleCanvas.SetActive(false);
                niddle1.SetActive(false);
                niddleCanvas2.SetActive(true);
                //blood anim
                //GM.isRight = true;

            }
            // Debug.Log(i);
        }
        else if (niddle1.tag == "wrong")
        {
            // niddle.SetActive(false);     
            // anim.SetActive(false);
            anim.enabled = false;
            niddle1.transform.position = niddle1.transform.position += new Vector3(0, 0.2f, 0);
            Debug.Log("wrong");
            i++;
            Debug.Log(i);
            if (i == 8)
            {
                Debug.Log("done");
                niddle1.SetActive(false);
                // GM.isRight = false;
                // niddleCanvas.SetActive(false);
                horribleAudio.PlayOneShot(horrible);
                MirrorFlipCamera(Camera.main);
                // niddleCanvas2.SetActive(true);

            }
        }
        
        // if(niddleCanvas2.activeInHierarchy == true){
        //     Debug.Log("hi");
        //     Debug.Log("OnMouseDown");
        //     clickAudio.PlayOneShot(click);
        //     if (niddle2.tag == "right")
        //     {
        //         //關閉浮起動畫
        //         anim.enabled = false;
        //         niddle2.transform.position = niddle2.transform.position += new Vector3(0, 0.2f, 0);
        //         Debug.Log("right");
        //         i++;
        //         Debug.Log(i);
        //         if (i == 8)
        //         {
        //             Debug.Log("done");
        //             niddleCanvas.SetActive(false);
        //             niddle2.SetActive(false);
        //             niddleCanvas2.SetActive(false);
        //             //blood anim
        //             // GM.isRight = true;
        //             blood2.SetActive(true);

        //         }
        //         // Debug.Log(i);
        //     }
        //     else if (niddle2.tag == "wrong")
        //     {
        //         // niddle.SetActive(false);     
        //         // anim.SetActive(false);
        //         anim.enabled = false;
        //         niddle2.transform.position = niddle2.transform.position += new Vector3(0, 0.2f, 0);
        //         Debug.Log("wrong");
        //         i++;
        //         Debug.Log(i);
        //         if (i == 8)
        //         {
        //             Debug.Log("done");
        //             niddle2.SetActive(false);
        //             // GM.isRight = false;
        //             // niddleCanvas.SetActive(false);
        //             horribleAudio.PlayOneShot(horrible);
        //             MirrorFlipCamera(Camera.main);
        //             // niddleCanvas2.SetActive(true);
        //         }
        //     }
        // }
    }

    private void MirrorFlipCamera(Camera camera)
    {



        Matrix4x4 mat = camera.projectionMatrix;



        mat *= Matrix4x4.Scale(new Vector3(-1, 1, 1));



        camera.projectionMatrix = mat;



    }
}
