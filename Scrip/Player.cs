using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    Animator animator;
    public static Rigidbody2D rb;
    BoxCollider2D coll;
    [Header("角色参数")]
    public float xvelocity;
    public static float speed = 8f;
    int force = 16;
    
    public LayerMask Ground;
    [Header("状态")]
    public bool jump;
    public bool Boost;
    public bool isOnGround;
    public bool grew;
    //public bool jumpHold;
    int jumptime = 1;
    public static float  boostChance = 6;
    void Start()
    {
        //if (!photonView.IsMine&&PhotonNetwork.IsConnected)
            //return;
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        //if (!photonView.IsMine&&PhotonNetwork.IsConnected)
            //return;
        if (!jump)
            jump = Input.GetButtonDown("Jump");
        if (!Boost)
            Boost = Input.GetKey(KeyCode.K);
        //if(!jumpHold)
            //jumpHold = Input.GetKey(KeyCode.Q);
        grew = Input.GetKey(KeyCode.U);
        
        if (Input.GetKeyUp(KeyCode.K)&& !isOnGround)
            boostChance -= 1;
        xvelocity = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed",Mathf.Abs(xvelocity));
        animator.SetBool("isOnGround", isOnGround);
        
    }

    private void FixedUpdate()
    {
        //if (!photonView.IsMine&&PhotonNetwork.IsConnected)
            //return;
        GM();
    
    }
    void GM()
    {
        
        rb.velocity = new Vector2(xvelocity * speed, rb.velocity.y);
        if(xvelocity<0)
            transform.localScale = new Vector3(-1, 1, 1);
        if(xvelocity>0)
            transform.localScale = new Vector3(1, 1, 1);
        if (jump && jumptime > 0&&boostChance>0)
        {
            rb.AddForce(new Vector2(0f, force), ForceMode2D.Impulse);
            jumptime--;
            boostChance -= 0.1f;
            jump = false;
        }
        if (Boost&&!isOnGround&&boostChance>0)
        {
            rb.AddForce(new Vector2(xvelocity*25f, 0f), ForceMode2D.Impulse);
            Boost = false;
       
        }
        if(boostChance<=0)
            Boost=false;
        if (coll.IsTouchingLayers(Ground))
        {
            isOnGround = true;
            jumptime = 1;

        }
        else
        {
            isOnGround = false;
        }

        if (jumptime <= 0)
            jump = false;
        //if (jumpHold && jumptime <= 0)
          //rb.AddForce(new Vector2(0f, 5), ForceMode2D.Force);
          if (Pineapple.havePineapple && grew)
          {if(xvelocity>0)
              Player.rb.transform.localScale = new Vector3(3f, 3f, 3f);
              if (xvelocity<0)
                 Player.rb.transform.localScale = new Vector3(-3f, 3f, 3f);
          }

          if (cherries.haveCherries && Input.GetKey(KeyCode.I))
          {if(xvelocity>0)
                  Player.rb.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
              if (xvelocity<0)
                  Player.rb.transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
              
          }
              
    }
}
