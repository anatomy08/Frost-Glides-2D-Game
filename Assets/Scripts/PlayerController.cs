using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] float TorqueAmount = 1f;
    [SerializeField] float GravityScaleAmount =8f;
    [SerializeField] float BoostSpeed = 50f;
    [SerializeField] float BaseSpeed = 30f;
    SurfaceEffector2D surfaceEffector2D;

    bool canMove = true;

    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove) // can move is already declared as true it controllers can be use.
        {
         RotatePlayer();
         RespondToBOost();
         RespondToGravity();
        }
    }

    public void DisableControls() // the public means i can access it to other classes for ex. Player Controller Class
    {
        canMove = false; // if can move is not true.
    }

    void RespondToGravity()

    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) // when push down, gravity increase
        {
            rb2d.gravityScale = GravityScaleAmount;
        }
        else
        {
            rb2d.gravityScale = 2f; // get back to its normal gravity when release pressed.
        }
    }

     void RespondToBOost()
    {
        // If we Push up, then speed up
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) 
        {
            surfaceEffector2D.speed = BoostSpeed;
        }
        // otherwise stay at normal speed
        else 
        {
            surfaceEffector2D.speed = BaseSpeed;
        }
        // access the surfaceeffector2d and change its speed
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(TorqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) // we put else if so we can sure only 1 condition is 
        // executed at a time.
        {
            rb2d.AddTorque(-TorqueAmount);// just put negative in the torqueAmount for Reverse
        }

        
    }
}
