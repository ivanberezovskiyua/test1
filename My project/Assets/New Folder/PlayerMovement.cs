using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed;
    float maxspeed;

    Rigidbody2D rigitbody2D;

    private void Start()
    {
        rigitbody2D = GetComponent<Rigidbody2D>();
        speed = 10;
    }

    private void FixedUpdate()
    {
        Walk();
        
    }

    private void Walk()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigitbody2D.AddForce(Vector2.left * speed);
            rigitbody2D.AddForce(Vector2.right * speed);
            
        }
        else if (Input.GetKey(KeyCode.D))
            rigitbody2D.AddForce(Vector2.right * speed);  
    }  
    
    


}