using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform pumkinPos;

	private float zDistance = 7f;
	private float yDistance = 4f;

	void Awake () {
		pumkinPos = GameObject.Find ("Pumkin").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.y = pumkinPos.position.y + yDistance;
		temp.z = pumkinPos.position.z - zDistance;
		transform.position = temp;
	}

} // class



































