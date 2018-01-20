using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBlocker : MonoBehaviour {

	public static int Blockattack;
	public int internalBlock;
	void Update () {
		internalBlock = Blockattack;
	}
}
