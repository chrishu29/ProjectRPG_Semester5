using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMng : MonoBehaviour {

	public static int ActiveQuestNum;
	public int InternalQuestNum;

	void update(){
		InternalQuestNum = ActiveQuestNum;
	}
}
