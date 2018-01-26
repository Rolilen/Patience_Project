using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextASide002 : MonoBehaviour {

	public GameObject playerSet;
	public Text textAside;

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
				textAside.text = "為了什麼而去努力，為了什麼而去堅持。";
				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "為了目標而行動，但你真的知道目標是什麼嗎。";
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
