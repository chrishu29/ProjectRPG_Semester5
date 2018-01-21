using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLevel : MonoBehaviour {

	public static int currentLevel = 1;
	public int interalLevel;
	void Update () {
		interalLevel = currentLevel;
	}
}
