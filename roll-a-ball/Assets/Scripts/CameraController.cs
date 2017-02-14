using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		//The position of the transform in world space.
		offset = transform.position - player.transform.position;
		
	}
	
	// LateUpdate is called after all Update functions have been called. This is useful to order script execution. 
	//For example a follow camera should always be implemented in LateUpdate because it tracks objects that might have moved inside Update.
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
