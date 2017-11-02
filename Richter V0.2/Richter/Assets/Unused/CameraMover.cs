using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

	//Declare Public Variables
	[HideInInspector]public bool moveable;
	[HideInInspector]public bool playerOnTrigger;
//	public float cameraDistance;
	public float cameraTravelSpeed;
	public GameObject holdCamera;
	public Transform pointA;
	public Transform pointB;

	//Declare Private Variables
	private float startTime;
	private float distanceBetweenPoints;

	// Use this for initialization
	void Start () {
		moveable = true;
		playerOnTrigger = false;
		startTime = Time.time;
		distanceBetweenPoints = Vector3.Distance (pointA.position, pointB.position);
	}
	
	// Update is called once per frame
	void Update () {
		startTime = Time.time;
	}

	//Move Camera when play touches trigger
	void OnTriggerStay (Collider other) {
		if (other.tag == "Player") {
			playerOnTrigger = true;
				if((moveable == true) && (playerOnTrigger == true)) {
//				Vector3 cameraMove = new Vector3 (transform.position.x + cameraDistance, transform.position.y, transform.position.z);
//				transform.position = cameraMove;
				float cameraDistance = (Time.time - startTime) * cameraTravelSpeed;
				float inbetweenDistance = cameraDistance / distanceBetweenPoints;
				transform.position = Vector3.Lerp (pointA.position, pointB.position, inbetweenDistance);
			}
			else {
				playerOnTrigger = false;
				return;
			}
		}
	}
}