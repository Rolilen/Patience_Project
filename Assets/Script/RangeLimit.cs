using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeLimit : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay (Collider playerLimit){
		if (playerLimit.tag == "player") {
			player.transform.position = new Vector3(90, 1, 55);
		}
	}
}
