using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

	public Rigidbody playerRigidbody;
	public float cameraRotationX = 0f;
	public float cameraRotationY = 0f;
	public float moveSpeed;
	public GameObject mainCamera;

	bool isJump;

	public GameObject Background;
	public GameObject startButtom;
	public GameObject quitButtom;
	public GameObject gameTitle;
	public AudioSource gameBgm;
	public bool playMove;

	int TextAsideScore;
	public GameObject TextAsideSet;
	public Text TextAsideScoreString;

	public static PlayerMove Pm;
	// Use this for initialization
	void Start () {
		Pm = this;

		playerRigidbody = GetComponent<Rigidbody> ();
		moveSpeed = 0.1f;
		playMove = false;

		TextAsideSet.SetActive (false);
		TextAsideScoreString.text = "TextAside Score : " + TextAsideScore + "/26";
		TextAsideScore = 0;

		isJump = true;

	}

	public void textAsideScoreAdd() {
		TextAsideScore++;
		TextAsideScoreString.text = "TextAside Score : " + TextAsideScore + "/26";
	}

	// Update is called once per frame
	void Update () {

		if (playMove) {

			float h = Input.GetAxis ("Horizontal");
			transform.Translate (Vector3.forward * h * moveSpeed);
		}

	}

	/*
	 
	bool isTwoJump;
	bool isTwoJumpSet;

	public void twoJumpSet(){
		isTwoJump = true;
		isTwoJumpSet = true;
	}
	float jumpTime;
	
	*/

	void OnTriggerStay(Collider collsionGround){
		if (collsionGround.tag == "Ground") {
			if (playMove) {
				if (Input.GetKeyDown (KeyCode.Space) && isJump) {
					isJump = false;
					playerRigidbody.AddForce (0, 350, 0);
				} else {
					isJump = true;
				}
			}
		}
	}

	void FixedUpdate()	{
		/*
		if (isJump) {
			Debug.Log (isJump + "= Not Jump");

			if (playMove && Input.GetKeyDown (KeyCode.Space) && isJump) {
				isJump = false;
				playerRigidbody.AddForce (0, 350, 0);
			}

		}
		if (!isJump) {
			Debug.Log (isJump + "= Is Jump");
		}

		if (playMove && Input.GetKeyDown (KeyCode.Space) && isJump) {
			isJump = false;
			playerRigidbody.AddForce (0, 350, 0);
		}
		*/
	}

	float rotationCameraX;
	float rotationCameraY;

	public float speedX = 1;
	public float speedY = 1;

	void LateUpdate(){


		rotationCameraX += Input.GetAxis ("Mouse X") * speedX;
		rotationCameraY += Input.GetAxis ("Mouse Y") * speedY;

		if (rotationCameraX > 360) {
			rotationCameraX -= 360;
		}

		if (rotationCameraX < 0) {
			rotationCameraX += 360;
		}

		if (rotationCameraY >= 30) {
			rotationCameraY = 30;
		}

		if (rotationCameraY <= -20) {
			rotationCameraY = -20;
		}

		if (playMove) {
			mainCamera.gameObject.transform.rotation = Quaternion.Euler (-rotationCameraY, rotationCameraX, 0);
			transform.rotation = Quaternion.Euler (0, rotationCameraX, 0);
		}
	}

	public void gameStart() {
		Background.SetActive (false);
		startButtom.SetActive (false);
		gameTitle.SetActive (false);
		quitButtom.SetActive (false);
		TextAsideSet.SetActive (true);
		gameBgm.Play ();
		playMove = true;
	}

	public void gameQuit() {
		Application.Quit();
	}

}
