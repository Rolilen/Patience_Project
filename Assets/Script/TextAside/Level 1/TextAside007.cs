using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside007 : MonoBehaviour {

	public Text textAside;
	public GameObject playerSet;
	PlayerMove Pm;

	public GameObject exitThisWorld;

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
				textAside.text = "無聲無息，稍縱即逝。";
				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "誰能一次就把握住這樣的機會。";
				textTime2 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime3 < Time.realtimeSinceStartup && textTime3 != 0) {
				textAside.text = "站在這裡的你有重複的能力。";
				textTime3 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime4 < Time.realtimeSinceStartup && textTime4 != 0) {
				textAside.text = "站在這裡的「你」，又是如何。";
				textTime4 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
				textAwake = false;

				exitThisWorld.SetActive (true);
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
