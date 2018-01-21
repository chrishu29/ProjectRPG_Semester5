using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolAI : MonoBehaviour {

	public static GameObject CurrentTarget;
	public GameObject Target1;
	public GameObject Target2;

	public static float OrcSpeed = 3;

	void Start () {
		CurrentTarget = Target1;
	}

	void Update () {
		if(transform.position == CurrentTarget.transform.position){
			TukerMang();
		}
		var step = OrcSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position,CurrentTarget.transform.position,step);
	}

	void TukerMang(){
		if(CurrentTarget == Target1){
			CurrentTarget = Target2;
			transform.LookAt (Target2.transform);
		}
		else{
			CurrentTarget = Target1;
			transform.LookAt (Target1.transform);
		}
	}

}
