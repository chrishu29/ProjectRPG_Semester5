using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCameraCtrl : MonoBehaviour {

	Vector2 mouseView;
	Vector2 viewSmoother;
	public float sensitivity=4;
	public float smoothing=2;

	GameObject Player;

	// Use this for initialization
	void Start () {
		Player = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		var vec1=new Vector2(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y"));
		vec1 = Vector2.Scale (vec1, new Vector2 (sensitivity * smoothing, sensitivity * smoothing));
		viewSmoother.x = Mathf.Lerp (viewSmoother.x, vec1.x, 1f / smoothing);
		viewSmoother.y = Mathf.Lerp (viewSmoother.y, vec1.y, 1f	 / smoothing);
		mouseView += viewSmoother;
		mouseView.y = Mathf.Clamp (mouseView.y, -20f, 25f);

		transform.localRotation = Quaternion.AngleAxis (-mouseView.y, Vector3.right);
		Player.transform.localRotation = Quaternion.AngleAxis (mouseView.x, Player.transform.up);
	}
}
