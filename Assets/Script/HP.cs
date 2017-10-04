using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

	public static int healthCount;
	public int innerHealt;
	public GameObject Health1;
	public GameObject Health2;
	public GameObject Health3;

	// Use this for initialization
	void Start () {
		healthCount = 1;
	}
	
	// Update is called once per frame
	void Update () {
		innerHealt = healthCount;

		if (healthCount == 1) {
			Health1.SetActive (true);
		}
		if (healthCount == 2) {
			Health2.SetActive (true);
		}
		if (healthCount == 3) {
			Health3.SetActive (true);
		}
	}
}
