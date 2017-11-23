using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManMenu : MonoBehaviour {

	public GameObject loadScreenObj;
	public Slider progressBar;

	AsyncOperation sinkronBar;

	public void ChangeScene(){
		StartCoroutine (loadingScreen());
	}

	IEnumerator loadingScreen()
	{
		loadScreenObj.SetActive (true);
		sinkronBar = SceneManager.LoadSceneAsync (0);
		sinkronBar.allowSceneActivation = false;

		while(sinkronBar.isDone==false){
			progressBar.value = sinkronBar.progress;
			if(sinkronBar.progress==0.9f)
			{
				progressBar.value = 1f;
				sinkronBar.allowSceneActivation = true;
			}
			yield return null;
		}
	}
}
