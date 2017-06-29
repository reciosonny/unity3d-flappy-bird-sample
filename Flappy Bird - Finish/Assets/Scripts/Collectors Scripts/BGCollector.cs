﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCollector : MonoBehaviour {
	
	private GameObject[] backgrounds;
	private GameObject[] grounds;

	//variable used for storing background X-Coordinate
	private float lastBGX;
	//variable used for storing ground X-Coordinate
	private float lastGroundX;
	
	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake() {
		backgrounds = GameObject.FindGameObjectsWithTag("Background");
		grounds = GameObject.FindGameObjectsWithTag("Ground");
		lastBGX = backgrounds[0].transform.position.x;

		foreach (GameObject item in backgrounds) {
			var xPosition = item.transform.position.x;
			if(lastBGX < xPosition)
				lastBGX = xPosition;
		}

		foreach (GameObject item in grounds) {
			var xPosition = item.transform.position.x;
			if(lastGroundX < xPosition)
				lastBGX = xPosition;
		}

		Debug.Log("last position backround: "+lastBGX);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D target) {
		Debug.Log("debugging...");
		float bgWidth = 0f;
		float groundWidth = 0f;
		
		if (target.tag == "Background")
		{
			Debug.Log("Background spotted!");
			bgWidth = ((BoxCollider2D)target).size.x;
            target.transform.position = new Vector2(lastBGX + bgWidth, target.transform.position.y);
        } else if (target.tag == "Ground") {
			
			groundWidth = ((BoxCollider2D)target).size.x;
            target.transform.position = new Vector2(lastBGX + groundWidth, target.transform.position.y);
		}
	}
}
