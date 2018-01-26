using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside006 : MonoBehaviour {

	public GameObject cube71Move;

	public Text textAside;
	public GameObject playerSet;
	PlayerMove Pm;

	bool textAwake;
	float textTime1;
	float textTime2;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (textAwake) {
			if (textTime1 < Time.realtimeSinceStartup && textTime1 != 0) {
				textAside.text = "有些東西，一旦錯過了時間點。";
				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "就算想要抓住他，卻也只能對著一片虛無哀嘆。";
				textTime2 = 0;
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

			cube71Move.SetActive (true);
			playerSet.SetActive (false);
		}

	}
}
