using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01 : MonoBehaviour {

	public GameObject camera;
	public GameObject Fadein;
	public GameObject Fadeout;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		StartCoroutine (StartCutscene ());
	}
	
	IEnumerator StartCutscene(){
		yield return new WaitForSeconds (4f);
		Player.SetActive (true);
		camera.SetActive (false);
		Fadeout.SetActive (true);
		yield return new WaitForSeconds (2f);
		Fadeout.SetActive (false);
		Fadein.SetActive (true);
	}
}
