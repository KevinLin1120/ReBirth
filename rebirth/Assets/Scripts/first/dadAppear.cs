using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadAppear : MonoBehaviour
{
    public GameObject dad;
    public Animator dadWalk;

    private void Start() {
        if (OVRInput.GetDown(OVRInput.RawButton.RShoulder))
        {
            if (dad != null)
            {
                dad.SetActive(true);
                dadWalk.enabled = true;
            }
        }
    }
    public void VROpenPanel()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RShoulder))
        {
            if (dad != null)
            {
                dad.SetActive(true);
                dadWalk.enabled = true;
            }
        }
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("OnMouseUpAsButton");
        if (dad != null)
        {
            dad.SetActive(true);
            dadWalk.enabled = true;
        }
    }
}
