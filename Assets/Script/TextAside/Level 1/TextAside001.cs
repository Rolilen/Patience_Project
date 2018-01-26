using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside001 : MonoBehaviour {

	public GameObject playerSet;
	public Text textAside;

	// Use this for initialization
	void Start () {
		textAwake = false;
	}

	bool textAwake;
	float textTime1;
	float textTime2;
	float textTime3;


	// Update is called once per frame
	void Update () {

		if (textAwake) {
			if (textTime1 < Time.realtimeSinceStartup && textTime1 != 0) {
				textAside.text = "也許你嘗試過走出去，但是卻被擋了下來。";
				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "也許你根本沒有嘗試就踏上這條路。";
				textTime2 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime3 < Time.realtimeSinceStartup && textTime3 != 0) {
				textAside.text = "方向早已被固定，如同無形的枷鎖。";
				PlayerMove.Pm.textAsideScoreAdd ();

				textTime3 = 0;
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

			playerSet.SetActive (false);

		}
		
	}
}


