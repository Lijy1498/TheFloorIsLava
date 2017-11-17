using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	public float levelNum = 2;

	int numBGPanels = 4;

	void Start (){
		GameObject box_go = GameObject.FindGameObjectWithTag ("Box");

		if (box_go == null) {
			Debug.LogError ("Couldn't find and object with tag 'Box'");
			return;
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		//Debug.Log ("Triggered: " + collider.name);
		//if (collider.tag == "Box") {
			//DestroyObject (collider.gameObject);
			//Debug.Log ("Triggered: " + collider.name);
		//}
			float heightOfBGObject = ((BoxCollider2D)collider).size.y;

			Vector3 pos = collider.transform.position;

		pos.y += heightOfBGObject * numBGPanels - 0.15f;

			collider.transform.position = pos;

		levelNum += 1;
		Debug.Log ("Level: " + levelNum);

		if (levelNum == 5) {
			GetComponentInParent<CameraMovement>().scrollSpeed += 0.005f;;
			levelNum = 0;
		}
	}

}
