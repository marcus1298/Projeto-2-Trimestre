using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
public float horizontalSpeed = 10f;
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
			MoveHorizontal(horizontalSpeed);
		}
		else{
			StopMoving();
		}
	}
	void MoveHorizontal(float speed){
		rb.velocity = new Vector2(speed, rb.velocity.y);

	}
	void StopMoving(){
		rb.velocity = new Vector2(0f, rb.velocity.y);
	}
}
