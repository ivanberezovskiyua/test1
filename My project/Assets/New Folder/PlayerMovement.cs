using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed;

    Rigidbody2D rigitbody2D;
    private Vector3  moveDirection;
    [SerializeField] private float maxspeed;
    [SerializeField] private float jumpForce;
    
    private void Start()
    {
        rigitbody2D = GetComponent<Rigidbody2D>();
        speed = 10;
    }

    private void Update()
    {
        Walk();
        Jump();
    }
    

    private void Walk()
    {
        moveDirection= Vector3.zero;

        speed = maxspeed;
        
       if (Input.GetKey(KeyCode.A))
       {
           moveDirection += Vector3.left;
           
       }
       else if (Input.GetKey(KeyCode.D))
       {
           moveDirection += Vector3.right;  
       }

       if (Input.GetKey(KeyCode.LeftShift))
       {
           speed *= 2;
       }
       
       
       moveDirection *= speed;
       moveDirection.y = rigitbody2D.velocity.y;
       rigitbody2D.velocity = moveDirection;


    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigitbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.TryGetComponent <Ground>(out Ground  playerMovement))
    }





}