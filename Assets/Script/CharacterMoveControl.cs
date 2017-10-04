using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveControl : MonoBehaviour {

	public float MSpeed = 6;
	public float JumpHeight = 300;
	private int CuLocked = 0;
	public Rigidbody rb;

	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		//movement forward and backward
		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (transform.forward * MSpeed);
		} else if (Input.GetKey (KeyCode.S)) {
			rb.AddForce (-transform.forward * MSpeed);
		}

		//movement right and left
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (transform.right * MSpeed);
		} else if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (-transform.right * MSpeed);
		}

		//jump
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (transform.up * JumpHeight);
		}


		//Cursor Shows up or hide cursor

		if (Input.GetKeyDown (KeyCode.LeftControl) && CuLocked == 0) {
			Cursor.lockState = CursorLockMode.None;
			CuLocked = 1;
		} else if(Input.GetKeyDown(KeyCode.LeftControl) && CuLocked==1){
			Cursor.lockState = CursorLockMode.Locked;
			CuLocked = 0;
		}
	}
}
