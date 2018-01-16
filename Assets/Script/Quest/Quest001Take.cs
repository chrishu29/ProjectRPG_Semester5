using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001Take : MonoBehaviour {
	public float theDistance;
	public GameObject actionDisplay;
	public GameObject actionText;
	public GameObject UIQuest;
	public GameObject thePlayer;
	public GameObject noticeCam;

	
	// Update is called once per frame
	void Update () {
		theDistance = PlayerCast.distanceFromTarget;
	}

	void OnMouseOver(){
		if (theDistance <= 2) {
			actionDisplay.SetActive (true);
			actionText.SetActive (true);
		}

		if (Input.GetButtonDown ("ActionButton")) {
			if (theDistance <= 2) {
				actionDisplay.SetActive (false);
				actionText.SetActive (false);
				UIQuest.SetActive (true);
				noticeCam.SetActive (true);
				thePlayer.SetActive (false);
				Cursor.lockState = CursorLockMode.None;
			}
		}
	}

	void OnMouseExit(){
		actionDisplay.SetActive (false);
		actionText.SetActive (false);

	}
}
