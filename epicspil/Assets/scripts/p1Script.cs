using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Script : MonoBehaviour {
    private Rigidbody2D rigidbody2D;
    public float jumpforce;
    public float movingSpeed;
    // Use this for initialization
    void Start () {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Debug.Log("Moving Left");
        //    gameObject.transform.position += new Vector3(-movingSpeed, 0, 0);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    Debug.Log("Moving Right");
        //    gameObject.transform.position += new Vector3(movingSpeed, 0, 0);
        //}
    }
}
