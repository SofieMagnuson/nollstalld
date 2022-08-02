using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //public Rigidbody2D RB;
    //public CapsuleCollider2D playCol;
    public SpriteRenderer SR;
    public float playerSpeed, playerJump;
    float movementPlayer;
    public bool isGrounded;


    void Start()
    {
        //RB = GetComponent<Rigidbody2D>();
        SR = GetComponent<SpriteRenderer>();

        playerSpeed = 3f;
        movementPlayer = 0f;
        //playerJump = 5f;
        //isGrounded = false;
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),  0, 0);
        {
            transform.position += movement * Time.deltaTime * playerSpeed;
        }

        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            SR.flipX = false;
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            SR.flipX = true;
        }
        //hoppa
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (isGrounded)
        //    {
        //        RB.velocity = new Vector2(RB.velocity.x, 0);
        //        RB.AddForce(new Vector2(0, playerJump), ForceMode2D.Impulse);
        //    }
        //    else
        //    {

        //    }

        //}
    }

    //private void FixedUpdate()
    //{
    //    if (Input.GetKeyUp(KeyCode.Space))
    //    {
    //        RB.velocity = new Vector2(RB.velocity.x, 0);
    //        RB.AddForce(new Vector2(0, playerJump), ForceMode2D.Impulse);
    //        isGrounded = false;


    //    }
    //}
}
