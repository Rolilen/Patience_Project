using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside_Obstacle001 : MonoBehaviour {

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
				textAside.text = "不要想抄捷徑，縱使是被強迫的。";
				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "你也只能循序漸進。";
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
			playerSet.SetActive (false);
		}

	}
}
