using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveControl : MonoBehaviour {
	private Rigidbody rb;
	private Vector3 normalizedVelocity;
	private int CuLocked = 0;
	public float MSpeed = 100;
	public float RunSpeed = 300;
	public float JumpHeight = 200;
	public float walk;
	public bool OnGround;
	public GameObject corsair;

	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		rb = GetComponent<Rigidbody> ();
		walk = 0;
		corsair.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		//movement forward and backward
		if (Input.GetKey(KeyCode.W)) {
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

		//run
		if (Input.GetKey (KeyCode.LeftShift)) {
			rb.AddForce (transform.forward * RunSpeed);
		}

		//jump
		if (OnGround && Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (transform.up * JumpHeight);
		}

		//Normal walk speed limiter
		if (rb.velocity.magnitude > walk) {
			normalizedVelocity = rb.velocity.normalized * walk;
			normalizedVelocity.y = rb.velocity.y;
			rb.velocity = normalizedVelocity;
		}


		//Cursor Shows up or hide cursor

		if (Input.GetKeyDown (KeyCode.LeftControl) && CuLocked == 0) {
			Cursor.lockState = CursorLockMode.None;
			CuLocked = 1;
			corsair.SetActive (false);
		} else if(Input.GetKeyDown(KeyCode.LeftControl) && CuLocked==1){
			Cursor.lockState = CursorLockMode.Locked;
			CuLocked = 0;
			corsair.SetActive (true);
		}
	}

	//on ground checking

	void OnCollisionEnter(Collision player){
		if (player.gameObject.CompareTag ("Ground")) {
			OnGround = true;
		}
	}

	void OnCollisionExit(Collision player){
		if(player.gameObject.CompareTag ("Ground")) {
			OnGround = false;
		}
	}
}
