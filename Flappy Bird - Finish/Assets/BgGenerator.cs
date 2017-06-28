using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgGenerator : MonoBehaviour {

	[SerializeField]
	private Transform bgToTransform;

	// Use this for initialization
	void Awake () {
		// var bgGameObject = transform.GetComponentsInChildren<Transform>();
		// Debug.Log(bgGameObject.Length);

		for (int i = 1; i <= 7; i++) {
			var newGameObject = Instantiate(bgToTransform);
			newGameObject.parent = transform;
			newGameObject.transform.position = new Vector2(7.2f * i, bgToTransform.position.y);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
