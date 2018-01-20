using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManMenu : MonoBehaviour {

	public int sceneNumber;

	public void ChangeScene(int toScene){
		SceneManager.LoadScene (toScene);
	}

	public void QuitGame(){
		Application.Quit();
	}

	public void OnTriggerEnter(){
		SceneManager.LoadScene (sceneNumber);
	}
}
