﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float speed;

    // called on the first frame of the game 
    void Start() {
        rb = GetComponent<Rigidbody>();
    }


	// Update is called once per frame
	void Update () {
   
	}

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
    }
}