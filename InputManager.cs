using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	string hAxis = "Horizontal";
	string vAxis = "Vertical";
	
	KeyCode greenButton = KeyCode.JoystickButton0;
	KeyCode redButton = KeyCode.JoystickButton1;
	KeyCode blueButton = KeyCode.JoystickButton2;
	KeyCode yellowButton = KeyCode.JoystickButton3;
	KeyCode jumpButton = KeyCode.JoystickButton5;
	
	Vector3 inputDir = new Vector3();
	
	PlayerCharacter pc;

	// Use this for initialization
	void Start () {
		pc = GetComponent<PlayerCharacter> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis (hAxis);
		float moveVertical = Input.GetAxis (vAxis);
		
		inputDir.Set (moveHorizontal, moveVertical, 0f);
		
		pc.SetDirection (inputDir);
		
		/*if (Input.GetButton(greenButton)) {
			pc.Cast(0);
		}
		if (Input.GetButton(redButton)) {
			pc.Cast(1);
		}
		if (Input.GetButton(blueButton)) {
			pc.Cast(2);
		}
		if (Input.GetButton(yellowButton)) {
			pc.Cast(3);
		}*/
		

		if (Input.GetKey(KeyCode.JoystickButton5)) {
			pc.Jump();
		}
		
	}
}
