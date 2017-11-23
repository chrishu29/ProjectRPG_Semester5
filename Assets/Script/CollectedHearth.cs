using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedHearth : MonoBehaviour {

	public AudioSource CollectSound;
	public GameObject Heart;
	public int HeartRotateSpeed;

	void update(){
		HeartRotateSpeed = 2;
		transform.Rotate (0, HeartRotateSpeed, 0, Space.World);
	}

	void OnTriggerEnter() {
		CollectSound.Play ();
		HP.healthCount += 1;
		Heart.SetActive (false);
	}
}
