using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

	CharacterController charCon;
	Vector3 moveDir;
	float maxSpeed = 250f;
	
	float jumpSpeed = 8f;
	float gravity = 20f;	
	
	List<Ability> abilities = new List<Ability>();
	
	GameObject room;

	// Use this for initialization
	void Start () {
		charCon = GetComponent<CharacterController> ();
		for (int i = 0; i < 4; i++) {
			abilities.Add(new Ability());
		}
		
		room = GameObject.Find("VRWorld");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		if (charCon.isGrounded) {
			charCon.SimpleMove (moveDir * maxSpeed * Time.fixedDeltaTime);
			room.transform.Translate((transform.position.x - room.transform.position.x) * Vector3.right);
		}
		else {
			
		}
	}

	public void SetDirection ( Vector3 moveInput) {
		moveDir = moveInput;
	}
	
	public void Jump () {
			if (charCon.isGrounded) {
			charCon.SimpleMove (Vector3.up * jumpSpeed);
			Debug.Log("Jump");
		}
	}
	
	public void Cast(int slot){
		abilities[slot].Cast();
	}

}
