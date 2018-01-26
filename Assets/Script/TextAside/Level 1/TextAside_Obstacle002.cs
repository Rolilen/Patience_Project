using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside_Obstacle002 : MonoBehaviour {

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
				textAside.text = "想要往上爬，卻被現實無情的踢落。";
				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "但冷靜下來卻能發現，那只是另一條道路的入口。";
				textTime2 = 0;

				PlayerMove.Pm.textAsideScoreAdd ();
				textAwake = false;
				playerSet.SetActive (true);
				transform.gameObject.SetActive (false);
			}
		}
	}

	void OnTriggerEnter (Collider textAsideTrigger) {

		if (textAsideTrigger.tag == "player") {
			textAwake = true;

			textTime1 = Time.realtimeSinceStartup;
			textTime2 = Time.realtimeSinceStartup + 5;

			playerSet.SetActive (false);
		}

	}
}
