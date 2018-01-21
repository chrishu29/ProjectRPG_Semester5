using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcEnemy : MonoBehaviour {

	public int enemyHealth = 10;
	public GameObject theOrc;
	public int orcStatus;
	public int BaseEXP = 10;
	public int CalculatedEXP;

	void DeductPoints(int damageAmount){
		enemyHealth -= damageAmount;
	}

	void Update () {
		if (enemyHealth <= 0) {
			if (orcStatus == 0) {
				StartCoroutine (DeathOrc ());
			}
		}
	}

	IEnumerator DeathOrc(){
		orcStatus = 5;
		CalculatedEXP = BaseEXP * GlobalLevel.currentLevel;
		GlobalEXP.currentEXP += CalculatedEXP;
		theOrc.GetComponent<Animation> ().Play ("orcdie");
		PatrolAI.OrcSpeed = 0;
		yield return new WaitForSeconds (0.5f);
		theOrc.SetActive (false);
	}
}
