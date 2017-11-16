using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float scrollSpeed = 0.01f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
			Vector3 pos = transform.position;
			pos.y += scrollSpeed;
			transform.position = pos;

	}
}
