using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public GameObject spawnpoint;
    public float speed = 40f;
    bool jump = false;
    float hMove = 0f;

    // Update is called once per frame
    void Update()
    {
        


            hMove = Input.GetAxisRaw("Horizontal") * speed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

        }
            
    }

    void FixedUpdate()
    {
        controller.Move(hMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
