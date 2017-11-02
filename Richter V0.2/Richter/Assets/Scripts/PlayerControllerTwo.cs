using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTwo : MonoBehaviour {

	//Declare Public Variables
	public float speed;
	public upAndDownBound boundZ;

	//Declare Private Variables
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		float moveHorizontal2 = Input.GetAxis ("Horizontal2");
		float moveVertical2 = Input.GetAxis ("Vertical2");
		Vector3 movement = new Vector3(moveHorizontal2, 0.0f, moveVertical2);
		rb.velocity = movement * speed;

		rb.position = new Vector3 (Mathf.Clamp(rb.position.x, -1000000000000.0f, 1000000000000.0f) ,Mathf.Clamp(rb.position.y, 0.0f, 7.0f) , Mathf.Clamp (rb.position.z, boundZ.minZ, boundZ.maxZ));
	}
}