using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalEXP : MonoBehaviour {

	public static int currentEXP;
	public int interalEXP;
	void Update () {
		interalEXP = currentEXP;
	}
}
