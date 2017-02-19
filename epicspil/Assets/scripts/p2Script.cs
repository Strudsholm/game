using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2Script : MonoBehaviour {


    Rigidbody2D rigidbody;
    public float jumpforce;
    public LayerMask groundlayer;
    bool grounded;
    public GameObject groundchecker;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        groundchecker = GameObject.Find("Ground");
    }
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.OverlapCircle(groundchecker.transform.position, 0.2f, groundlayer);
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            //rigidbody.AddForce(transform.up * jumpforce * 100);
            rigidbody.AddForce(new Vector3(0, 100*jumpforce, 0));
            
            

        }
	}
}
