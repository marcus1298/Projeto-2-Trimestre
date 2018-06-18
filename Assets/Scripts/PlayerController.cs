using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
public float horizontalSpeed = 5f;
public float jumpSpeed = 600f;
	// Use this for initialization


Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxisRaw("Horizontal");//-1; esquerda, 1:direita
		float horizontalPlayerSpeed = horizontalSpeed * horizontalInput;
		if(horizontalPlayerSpeed !=0){
			MoveHorizontal(horizontalPlayerSpeed);
		}
		else{
			StopMovingHorizontal();
		}
		if(Input.GetButtonDown("Jump")){
			jump();
		}
	}
	void MoveHorizontal(float speed){
		rb.velocity = new Vector2(speed, rb.velocity.y);

	}
	void StopMovingHorizontal(){
		rb.velocity = new Vector2(0f, rb.velocity.y);
	}
	void jump(){
		rb.AddForce(new Vector2(0f, jumpSpeed));
	}
}
