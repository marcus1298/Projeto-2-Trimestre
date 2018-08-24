﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour {
	public float speed = 2f;

	Rigidbody2D rb;
	SpriteRenderer sr;
	// Use this for initialization
	void Start () {
	rb = GetComponent<Rigidbody2D>();	
	sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < GM.instance.yMinLive){
			Destroy(gameObject);
		}
		Move();
	}
	void Move(){
		rb.velocity = new Vector2(speed, rb.velocity.y);
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.CompareTag("Turn")){
			Flip();
		}
	}
	
	void Flip(){
		speed = - speed;
		if(speed<0){
			sr.flipX = true;
		}
		else if(speed > 0){
			sr.flipX = false;
		}

	}
}
