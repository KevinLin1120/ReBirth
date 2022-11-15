using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;//移動速度
    public float gravity = -9.81f;//重力

    Vector3 velocity;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");//input水平
        float z = Input.GetAxis("Vertical");//input垂直

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}