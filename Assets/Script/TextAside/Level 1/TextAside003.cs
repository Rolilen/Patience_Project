using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside003 : MonoBehaviour {

	public Text textAside;
	public GameObject playerSet;
	PlayerMove Pm;

	bool textAwake;
	float textTime1;
	float textTime2;
	float textTime3;
	float textTime4;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (textAwake) {
			if (textTime1 < Time.realtimeSinceStartup && textTime1 != 0) {
				textAside.text = "「你」操作著你邁向目標。";
				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "這樣的世界你隨時都可以離開。";
				textTime2 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime3 < Time.realtimeSinceStartup && textTime3 != 0) {
				textAside.text = "那，誰又操作著「你」前行。";
				textTime3 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime4 < Time.realtimeSinceStartup && textTime4 != 0) {
				textAside.text = "那樣的世界，可以隨時離開嗎。";
				textTime4 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
				textAwake = false;

				transform.gameObject.SetActive (false);
				playerSet.SetActive (true);
			}
		}
	}

	void OnTriggerEnter (Collider textAsideTrigger) {

		if (textAsideTrigger.tag == "player") {
			textAwake = true;

			textTime1 = Time.realtimeSinceStartup;
			textTime2 = Time.realtimeSinceStartup + 5;
			textTime3 = Time.realtimeSinceStartup + 10;
			textTime4 = Time.realtimeSinceStartup + 15;

			playerSet.SetActive (false);
		}

	}
}
