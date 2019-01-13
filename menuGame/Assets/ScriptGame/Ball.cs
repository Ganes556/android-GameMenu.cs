using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float powerStart = 50f;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P)) {
            rb.isKinematic = false; 
            rb.AddForce(new Vector2(200f, powerStart));
        }
	}

    void OnCollisionEnter(Collision collision){
        if (collision.collider.CompareTag("Brick")) {
            Destroy(collision.gameObject);
        }
    }
}
