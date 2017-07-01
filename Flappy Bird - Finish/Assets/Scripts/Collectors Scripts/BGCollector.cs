using System.Collections;
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

		// Debug.Log("last position backround: "+lastBGX);
	}

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
        BgGenerator.instance.GenerateBackground();
		GrndGenerator.instance.GenerateGround();


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
				lastGroundX = xPosition;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D target) {
		float bgWidth = 0f;
		float groundWidth = 0f;
		
		if (target.tag == "Background") {
			// Debug.Log("Background spotted!");
			bgWidth = ((BoxCollider2D)target).size.x;
			var bgPosition = target.transform.position;
            bgPosition = new Vector2(lastBGX + bgWidth, target.transform.position.y);
			target.transform.position = bgPosition;

			lastBGX = bgPosition.x;
        } else if (target.tag == "Ground") {
			groundWidth = GrndGenerator.instance.groundWidth; //((BoxCollider2D)target).size.x;
			var groundPosition = target.transform.position;
            groundPosition = new Vector2(lastGroundX + groundWidth, target.transform.position.y);
			target.transform.position = groundPosition;

			lastGroundX = groundPosition.x;
		}


	}
}
