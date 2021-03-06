﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Script : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float jumpforce;
    public float movingSpeed;
    Sprite[] s1, s2, s3;
    public float speed;
    public int selectedCharacter;
    private SpriteRenderer spriteRenderer;
    public LayerMask groundlayer;
    bool grounded;
    public GameObject groundchecker;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(new Vector3(0, 100 * jumpforce, 0));
        selectedCharacter = 1;
        s1 = Resources.LoadAll<Sprite>("p1_spritesheet");
        s2 = Resources.LoadAll<Sprite>("p2_spritesheet");
        s3 = Resources.LoadAll<Sprite>("p3_spritesheet");

        animator = GetComponent<Animator>();

        groundchecker = GameObject.Find("Ground");

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = (Sprite)s1[0]; // set the sprite to sprite1
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 0.1f);

        grounded = Physics2D.OverlapCircle(groundchecker.transform.position, 0.2f, groundlayer);
        Debug.Log(grounded);

        // If it hits something...
        //if (hit != null && hit.transform != null)
        //{
        //    grounded = true;
        //}

        // Walking animation
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) && selectedCharacter == 1)
        {
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }




        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (selectedCharacter < 3)
            {
                selectedCharacter++;
                animator.SetInteger("player", selectedCharacter);
            }

            else
            {
                selectedCharacter = 1;
                animator.SetInteger("player", selectedCharacter);
            }

        }
        if (selectedCharacter == 1)
        {
            Debug.Log("Change sprite");
            spriteRenderer.sprite = (Sprite)s1[0];
            if (!grounded)
            {
                spriteRenderer.sprite = (Sprite)s1[6];
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Moving Left");
                gameObject.transform.position += new Vector3(-speed * 2, 0, 0);
                GlobalVariables.placement = gameObject.transform.position;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Moving Right");
                gameObject.transform.position += new Vector3(speed * 2, 0, 0);
                GlobalVariables.placement = gameObject.transform.position;
            }
        }
        else if (selectedCharacter == 2)
        {
            Debug.Log("Change sprite");
            spriteRenderer.sprite = (Sprite)s2[0];
            if (!grounded)
            {
                spriteRenderer.sprite = (Sprite)s2[6];
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Moving Left");
                gameObject.transform.position += new Vector3(-speed, 0, 0);
                GlobalVariables.placement = gameObject.transform.position;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Moving Right");
                gameObject.transform.position += new Vector3(speed, 0, 0);
                GlobalVariables.placement = gameObject.transform.position;
            }
            Debug.Log(grounded);
            if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
            {
                //rigidbody.AddForce(transform.up * jumpforce * 100);
                rigidbody2D.AddForce(new Vector3(0, 100 * jumpforce, 0));


            }
            //if (Input.GetKeyDown(KeyCode.UpArrow) & grounded)
            //{
            //   gameObject.transform.position += new Vector3(0, jumpspeedp2, 0);
            //    //rigidbody.AddForce(transform.up * jumpspeedp2 * 100);
            //}

        }
        else if (selectedCharacter == 3)
        {
            Debug.Log("Change sprite");
            spriteRenderer.sprite = (Sprite)s3[0];
            if (!grounded)
            {
                spriteRenderer.sprite = (Sprite)s3[6];
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Moving Left");
                gameObject.transform.position += new Vector3(-speed, 0, 0);
                GlobalVariables.placement = gameObject.transform.position;

            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Moving Right");
                gameObject.transform.position += new Vector3(speed, 0, 0);
                GlobalVariables.placement = gameObject.transform.position;
            }
        }
    }

    //void LateUpdate()
    //{
    //    if (selectedCharacter == 1)
    //    {
    //        Debug.Log("Change sprite");
    //        spriteRenderer.sprite = (Sprite)s1[0];
    //    }
    //    if (selectedCharacter == 2)
    //    {
    //        Debug.Log("Change sprite");
    //        spriteRenderer.sprite = (Sprite)s2[0];
    //    }
    //    if (selectedCharacter == 3)
    //    {
    //        Debug.Log("Change sprite");
    //        spriteRenderer.sprite = (Sprite)s3[0];
    //    }
    //}
}
