using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/** 
		 * Time.deltaTime
		 * The time in seconds it took to complete the last frame (Read Only).

Use this function to make your game frame rate independent.

If you add or subtract to a value every frame chances are you should multiply with Time.deltaTime. 
		**/
		transform.Rotate (new Vector3 (15, 30, 45) *Time.deltaTime);
		
	}
}
