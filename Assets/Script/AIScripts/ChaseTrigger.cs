using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseTrigger : MonoBehaviour {

	public GameObject Player;
	public GameObject Reset;

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")){
			PatrolAI.CurrentTarget = Player;
			PatrolAI.OrcSpeed = 5;
			transform.LookAt (Player.transform);
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			PatrolAI.CurrentTarget = Reset;
			PatrolAI.OrcSpeed = 3;
		}
	}
}
