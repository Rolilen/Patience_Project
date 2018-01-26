using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAside : MonoBehaviour {

	public Text textAside;
	public Text arrival;
	public GameObject exitButtom;

	public AudioSource pickUp;

	// Use this for initialization
	void Start () {

	}
	/*
	bool textSet1;
	bool textSet2;
	bool textSet3;
	bool textSet4;

	float textTime1 = 0;
	float textTime2 = 0;
	float textTime3 = 0;
	float textTime4 = 0;
	float textTime5 = 0;
	float textTime6 = 0;
	float textTime7 = 0;
	*/
	// Update is called once per frame
	void Update () {
		/*
		if (textSet1) {
			if (textTime1 < Time.realtimeSinceStartup && textTime1 != 0) {
				textAside.text = "寬廣的世界卻往這邊走的你。";
				textTime1 = 0;
			}

			if (textTime2 < Time.realtimeSinceStartup && textTime2 != 0) {
				textAside.text = "是否有想過這是一種被迫呢。";
				textTime2 = 0;
				textSet1 = false;
			}

		}

		if (textSet2) {
			if (textTime3 < Time.realtimeSinceStartup && textTime2 == 0) {
				textAside.text = "不要想抄捷徑，任何事都是循序漸進。";
				textTime3 = 0;
				textSet2 = false;
			}

		}

		if (textSet3) {
			if (textTime4 < Time.realtimeSinceStartup && textTime4 != 0) {
				textAside.text = "為了目標而行動，但路途總是遙遠或被限定的。";
				textTime4 = 0;
			}
			if (textTime5 < Time.realtimeSinceStartup && textTime5 != 0) {
				textAside.text = "這樣的世界又是誰創造的。";
				textTime5 = 0;
			}
			if (textTime6 < Time.realtimeSinceStartup && textTime6 != 0) {
				textAside.text = "「你」操作著你前進，那誰又操作著「你」。";
				textTime6 = 0;
				textSet3 = false;
			}

		}

		if (textSet4) {
			if (textTime7 < Time.realtimeSinceStartup && textTime7 != 0) {
				textAside.text = "恭喜你，到達了目標，你可以自由探索世界了。";
				textTime7 = 0;
				exitButtom.SetActive (true);
				textSet4 = false;
			}
		}
*/
	}

	void OnTriggerEnter (Collider coll){
		/*
		if (coll.tag == "TextAside") {
			textSet1 = true;
			textTime1 = Time.realtimeSinceStartup;
			textTime2 = Time.realtimeSinceStartup + 5;
			coll.gameObject.SetActive (false);
		}

		if (coll.tag == "TextAside1") {
			textSet2 = true;
			textTime3 = Time.realtimeSinceStartup;
			coll.gameObject.SetActive (false);
		}

		if (coll.tag == "TextAside2") {
			textSet3 = true;
			textTime4 = Time.realtimeSinceStartup;
			textTime5 = Time.realtimeSinceStartup + 5;
			textTime6 = Time.realtimeSinceStartup + 10;
			coll.gameObject.SetActive (false);
		}

		if (coll.tag == "TextAside3") {
			textSet4 = true;
			textTime7 = Time.realtimeSinceStartup;
			coll.gameObject.SetActive (false);
		}
		*/
	}

	void OnTriggerStay (Collider coll) {
		if (coll.tag == "arrival") {
			if (Input.GetKeyDown (KeyCode.J)) {
				arrival.text = "arrival : 1";
				pickUp.Play ();
				Destroy (coll.gameObject);
			}
		}
	}

}
