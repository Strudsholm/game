using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Script : MonoBehaviour {
    private Rigidbody2D rigidbody2D;
    public float jumpforce;
    public float movingSpeed;
    Sprite s1, s2, s3;
    public float speed;
    public int selectedCharacter;
    private SpriteRenderer spriteRenderer;
    public LayerMask groundlayer;
    bool grounded;
    public GameObject groundchecker;

    // Use this for initialization
    void Start () {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(new Vector3(0, 100 * jumpforce, 0));
        selectedCharacter = 1;
        s1 = Resources.Load("p1_spritesheet", typeof(Sprite)) as Sprite;
        s2 = Resources.Load("p2_spritesheet", typeof(Sprite)) as Sprite;
        s3 = Resources.Load("p3_spritesheet", typeof(Sprite)) as Sprite;

        groundchecker = GameObject.Find("Ground");

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = s1; // set the sprite to sprite1
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 0.1f);

        // If it hits something...
        if (hit != null && hit.transform != null)
        {
            grounded = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectedCharacter < 3)
                selectedCharacter++;
            else
                selectedCharacter = 1;
        }
        if (selectedCharacter == 1)
        {
            Debug.Log("Change sprite");
            spriteRenderer.sprite = s1;
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
            spriteRenderer.sprite = s2;

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
            spriteRenderer.sprite = s3;

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
