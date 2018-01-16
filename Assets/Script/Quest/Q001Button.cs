using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001Button : MonoBehaviour {

	public GameObject thePlayer;
	public GameObject noticeCam;
	public GameObject uiQuest;
	public GameObject ActiveQuestBox;
	public GameObject QObjective01;
	public GameObject QObjective02;
	public GameObject QObjective03;


	public void AccQuest(){
		thePlayer.SetActive (true);
		noticeCam.SetActive (false);
		uiQuest.SetActive (false);
		StartCoroutine (setQuestUI ());
	}

	IEnumerator setQuestUI(){
		ActiveQuestBox.GetComponent<Text> ().text = "My 1st Weapon";
		QObjective01.GetComponent<Text> ().text = "Reach the clearing in the woods";
		QObjective02.GetComponent<Text> ().text = "Open Chest";
		QObjective03.GetComponent<Text> ().text = "Retrive weapon";

		QuestMng.ActiveQuestNum = 1;
		yield return new WaitForSeconds (0.5f);
		ActiveQuestBox.SetActive (true);
		yield return new WaitForSeconds (1f);
		QObjective01.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		QObjective02.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		QObjective03.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		ActiveQuestBox.SetActive (false);
		QObjective01.SetActive (false);
		QObjective02.SetActive (false);
		QObjective03.SetActive (false);

	}

}
