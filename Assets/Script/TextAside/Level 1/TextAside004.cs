using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside004 : MonoBehaviour {

	public Text textAside;
	public GameObject playerSet;
	PlayerMove Pm;

	bool textAwake;
	float textTime1;
	float textTime2;
	float textTime3;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (textAwake) {
			if (textTime1 < Time.realtimeSinceStartup && textTime1 != 0) {
				textAside.text = "在這一成不變的枯燥世界。";

				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "然而「你」沒有選擇離開(Exit)，又或者。";
				textTime2 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime3 < Time.realtimeSinceStartup && textTime3 != 0) {
				textAside.text = "你只是無法退出(Quit)呢。";
				textTime3 = 0;
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

			playerSet.SetActive (false);
		}

	}
}
