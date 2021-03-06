﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    public static float height;
    public static Vector3 placement;
    public static float speedGlobal;
}

public class characters : MonoBehaviour
{

    int selectedCharacter;
    GameObject p1, groundchecker, character;
    Rigidbody2D rigidbody;
    Vector3 movement;
    public float speed;
    bool grounded;
    public float jumpspeedp2;
    public LayerMask groundlayer;
    Sprite s1, s2, s3;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        p1 = GameObject.Find("p1");
        groundchecker = GameObject.Find("Ground");
        character = GameObject.Find("Characters");
        selectedCharacter = 1;
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        GlobalVariables.speedGlobal = speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectedCharacter < 3)
                selectedCharacter++;
            else
                selectedCharacter = 1;
        }
        if (selectedCharacter == 1)
        {
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

            //grounded = Physics2D.OverlapCircle(groundchecker.transform.position, 0.2f, groundlayer);

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Moving Left");
                character.transform.position += new Vector3(-speed, 0, 0);
                GlobalVariables.placement = gameObject.transform.position;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Moving Right");
                character.transform.position += new Vector3(speed, 0, 0);
                GlobalVariables.placement = gameObject.transform.position;
            }

            //if (Input.GetKeyDown(KeyCode.UpArrow) & grounded)
            //{
            //   gameObject.transform.position += new Vector3(0, jumpspeedp2, 0);
            //    //rigidbody.AddForce(transform.up * jumpspeedp2 * 100);
            //}
           
        }
        else if (selectedCharacter == 3)
        {

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
}
