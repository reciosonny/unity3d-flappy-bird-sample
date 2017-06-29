using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgGenerator : MonoBehaviour {

	[SerializeField]
	private Transform bgToClone;

	// Use this for initialization
	void Awake () {
		for (int i = 1; i <= 7; i++) {
			var newGameObject = Instantiate(bgToClone);
			newGameObject.parent = transform;
			newGameObject.transform.position = new Vector2(7.2f * i, bgToClone.position.y);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
