using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedHearth : MonoBehaviour {

	public AudioSource CollectSound;
	public GameObject Heart;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter() {
		CollectSound.Play ();
		HP.healthCount += 1;
		Heart.SetActive (false);
	}
}
