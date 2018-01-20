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


	public void AccQuest(){
		thePlayer.SetActive (true);
		noticeCam.SetActive (false);
		uiQuest.SetActive (false);
		StartCoroutine (setQuestUI ());
		Cursor.lockState = CursorLockMode.Locked;
	}

	IEnumerator setQuestUI(){
		ActiveQuestBox.GetComponent<Text> ().text = "My 1st Quest";
		QObjective01.GetComponent<Text> ().text = "Recover your Health";

		QuestMng.ActiveQuestNum = 1;
		yield return new WaitForSeconds (0.5f);
		ActiveQuestBox.SetActive (true);
		yield return new WaitForSeconds (1f);
		QObjective01.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		ActiveQuestBox.SetActive (false);
		QObjective01.SetActive (false);

	}


	public void DecQuest(){
		thePlayer.SetActive (true);
		noticeCam.SetActive (false);
		uiQuest.SetActive (false);
		Cursor.lockState = CursorLockMode.Locked;
	}
}
