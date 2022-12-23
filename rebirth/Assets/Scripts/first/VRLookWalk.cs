using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class VRLookWalk : MonoBehaviour {
    public float speed;
    public XRNode inputSource;
    private XRRig rig;
    private Vector2 inputAxis;
    public CharacterController controller;
    void Start (){
        // cc = GetComponent<CharacterController>();
        // character = GetComponent<CharacterController>();
        rig = GetComponent<XRRig>();
    }
    // Update is called once per frame
    void Update () {
        // if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f){
        //     moveForward = true;
        // }
        // else {
        //     moveForward = false;
        // }

        // if (moveForward) {
        //     Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
        //     cc.SimpleMove(forward * speed);
        // }
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }

    private void FixedUpdate() {

        Quaternion headYaw = Quaternion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        controller.Move(direction * Time.fixedDeltaTime*speed);
    }
}