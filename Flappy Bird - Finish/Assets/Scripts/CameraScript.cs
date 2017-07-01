using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public static float offsetX;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		MoveTheCamera();
	}

	void MoveTheCamera() {
		Vector3 temp = transform.position;
		temp.x = BirdScript.instance.GetPositionX();

		transform.position = temp;
	}
}
