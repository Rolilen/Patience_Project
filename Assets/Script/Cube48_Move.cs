using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube48_Move : MonoBehaviour {

	public GameObject playerParentSet;

	float moveTimeX;
	float moveTimeZ;
	float alphaX;
	float alphaZ;
	float loopX;
	float loopZ;

	void Start () {
		alphaX = transform.localPosition.x;
		alphaZ = transform.localPosition.z;
		loopX = (transform.localPosition.x + 4.0f);
		loopZ = (transform.localPosition.z - 4.0f);
		moveTimeX = 0.02f;
		moveTimeZ = -moveTimeX;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (alphaZ < loopZ || alphaZ > 0.0f) {
			moveTimeZ = -moveTimeZ;
		}

		if (alphaX > loopX || alphaX < 0.0f) {
			moveTimeX = -moveTimeX;
		}

		transform.localPosition = new Vector3 (alphaX, transform.localPosition.y, alphaZ);

		alphaX += moveTimeX;
		alphaZ += moveTimeZ;
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
