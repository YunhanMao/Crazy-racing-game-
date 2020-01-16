using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	public float rotationspeed = 5;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		float mouseHorizontal = rotationspeed*Input.GetAxis("Mouse X");//get a value from moving the mouse left/right
		float mouseVertical = rotationspeed*Input.GetAxis("Mouse Y");//get a value from moving the mouse up/down

		Vector3 newRotation = new Vector3 (transform.eulerAngles.x-mouseVertical, //rotate About the x-axis by our vertical mouse value
			transform.eulerAngles.y+mouseHorizontal,//rotate About the y-axis by our horizontal mouse value
			transform.eulerAngles.z);
		transform.eulerAngles = newRotation;//set the rotation
		if (Input.GetKey (KeyCode.W)) { //if the w key is currently pressed down
			transform.Translate (0f, 0f, 0.2f);//move the player 0.2 units in the positive z direction
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0f, 0f, -0.2f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-0.2f, 0f, 0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0.2f, 0f, 0f);
		}	
		if (Input.GetKey (KeyCode.Space)) {
			transform.Translate (0f, 0.2f, 0f);
		}


		}
	}

