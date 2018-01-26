using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube71_Move : MonoBehaviour {

	public GameObject playerParentSet;
	float targetZ;
	// Use this for initialization
	void Start () {
		targetZ = transform.position.z + 35.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z < targetZ) {
			transform.position += new Vector3 (0, 0, 0.2f);
		}
	}

	void OnTriggerEnter (Collider playerMoveSet){
		if (playerMoveSet.tag == "playerMove") {
			playerMoveSet.gameObject.transform.SetParent (this.transform);
		}
	}

	void OnTriggerExit (Collider playerMoveSet){
		if (playerMoveSet.tag == "playerMove") {
			playerMoveSet.gameObject.transform.SetParent (playerParentSet.transform);
		}
	}

}
