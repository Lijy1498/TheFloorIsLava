﻿using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour {

	public float maxSpeed = 10f;
	public float jumpForce = 900f;

	Rigidbody2D rigid2D;

	bool grounded = false;
	bool inLava = false;
	public Transform groundCheck;
	float groundRadius = 0.3f;
	public LayerMask whatIsGround;
	public LayerMask whatIsLava;

	// Use this for initialization
	void Start () {
		rigid2D = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		inLava = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsLava);

		if (inLava == true) {
			Application.LoadLevel(0);
		}

		float move = Input.GetAxis ("Horizontal2");

		rigid2D.velocity = new Vector2 (move * maxSpeed, rigid2D.velocity.y);
	}

	// Update is called once per frame
	void Update()
	{
		if (grounded == true && Input.GetKeyDown (KeyCode.W))
		{
			rigid2D.AddForce (new Vector2 (0, jumpForce));
		}
	}
}
