using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextAsideMoveSet001 : MonoBehaviour {


	public GameObject Cube48MoveSet;
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
				textAside.text = "有時候我們會遇到一個時間點。";
				textTime1 = 0;

				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "在這個時間點如果做了對的事。";
				textTime2 = 0;

				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime3 < Time.realtimeSinceStartup && textTime3 != 0) {
				textAside.text = "也許可以拉近與目標的距離";
				textTime3 = 0;

				PlayerMove.Pm.textAsideScoreAdd ();
			}

			if (textTime4 < Time.realtimeSinceStartup && textTime4 != 0) {
				textAside.text = "這個時間點，叫做機會。";
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

			Cube48MoveSet.SetActive (true);

			playerSet.SetActive (false);
		}

	}

}
