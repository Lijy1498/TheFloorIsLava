using UnityEngine;
using System.Collections;

public class LavaMovement : MonoBehaviour {

	Transform MainCamera;

	float offsetY;

	// Use this for initialization
	void Start () {
		GameObject camera_go = GameObject.FindGameObjectWithTag ("MainCamera");

		if (camera_go == null) {
			Debug.LogError ("Couldn't find and object with tag 'MainCamera'");
			return;
		}

		MainCamera = camera_go.transform;

		offsetY = transform.position.y - MainCamera.position.y;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (MainCamera != null) {
			Vector3 pos = transform.position;
			pos.y = MainCamera.position.y + offsetY;
			transform.position = pos;
		}

	}
}
