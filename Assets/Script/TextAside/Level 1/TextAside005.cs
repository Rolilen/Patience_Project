using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside005 : MonoBehaviour {

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
				textAside.text = "走過茫茫一片的路途，還有多久才能到目標。";
				textTime1 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "仔細想想，真的有目標存在嗎。";
				textTime2 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime3 < Time.realtimeSinceStartup && textTime3 != 0) {
				textAside.text = "亦或者，那是個距離不斷遠離的。";
				textTime3 = 0;
				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime4 < Time.realtimeSinceStartup && textTime4 != 0) {
				textAside.text = "遙不可及的妄想呢。";
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
