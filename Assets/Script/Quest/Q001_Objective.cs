using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q001_Objective : MonoBehaviour {

	public GameObject Objective;
	public int ObjDone;

	void Update () {
		if (ObjDone == 2) {
			if (Objective.transform.localScale.y <= 0.0f) {
				ObjDone = 0;
				Objective.SetActive (false);
			}
		} else {
			Objective.transform.localScale -= new Vector3 (0.0f, 0.1f, 0.0f);
		}
	}

	void OnTriggerEnter(){
		StartCoroutine (ObjectiveDone());
	}

	IEnumerator ObjectiveDone(){
		Objective.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		ObjDone += 1;
	}
}
