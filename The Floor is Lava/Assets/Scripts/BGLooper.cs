using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int numBGPanels = 3;

	void Start (){
		GameObject box_go = GameObject.FindGameObjectWithTag ("Box");

		if (box_go == null) {
			Debug.LogError ("Couldn't find and object with tag 'Box'");
			return;
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		//Debug.Log ("Triggered: " + collider.name);
		if (collider.tag == "Box") {
			DestroyObject (collider.gameObject);
			Debug.Log ("Triggered: " + collider.name);
		}
			float heightOfBGObject = ((BoxCollider2D)collider).size.y;

			Vector3 pos = collider.transform.position;

		pos.y += heightOfBGObject * numBGPanels - 0.15f;

			collider.transform.position = pos;
	}

}
