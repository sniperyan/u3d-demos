using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * MonoBehaviour is the base class from which every Unity script derives
 **/
public class PlayerController : MonoBehaviour {

	//public variable can be set in Inspector
	public float speed;
	public Text countText;
	public Text WinText;

	private Rigidbody rb;
	private int count;



	// Use this for initialization
	void Start () {
		//Returns the component of Type type if the game object has one attached, null if it doesn't.
		rb = GetComponent<Rigidbody> ();
		count = 0;
		setCountText ();
		WinText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//固定的时间间隔来被调用,看起来运动更平滑,FixedUpdate should be used instead of Update when dealing with Rigidbody
	void FixedUpdate(){
		//x
		float moveHorizontal = Input.GetAxis ("Horizontal");
		//z
		float moveVertical = Input.GetAxis ("Vertical");
		//Representation of 3D vectors and points.  Vector3(float x, float y, float z);
		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
		rb.AddForce (movement*speed);

		
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count++;
			setCountText ();
		}
		//Destroy(other.gameObject);
	}
	void setCountText(){
		countText.text = "score:" + count.ToString ();
		//countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
			WinText.text = "You Win!";
		
		}
	}

}
