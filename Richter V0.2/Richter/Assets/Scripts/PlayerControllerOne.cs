using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerOne : MonoBehaviour {

	//Declare Public Variables
	public float speed;
//	public GameObject ground;
//	public GameObject frontBound;
//	public GameObject backBound;
//	public GameObject leftBound;
//	public GameObject rightBound;
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
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * speed;

		rb.position = new Vector3 (Mathf.Clamp(rb.position.x, -1000000000000.0f, 1000000000000.0f) ,Mathf.Clamp(rb.position.y, 0.0f, 7.0f) , Mathf.Clamp (rb.position.z, boundZ.minZ, boundZ.maxZ));
	}

	void OnTriggerEnter (Collider other){
		if(other.tag == "Boundary"){
			
		}
	}
}