using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {


	[SerializeField]
	private float forwardSpeed = 7f;
	[SerializeField]
	private Rigidbody2D myRigidBody;
	public static BirdScript instance;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			didFlap = true;
		}
	}

	private bool didFlap = false;
	void FixedUpdate() {
		
		MoveBird();
		if (didFlap)
		{
			myRigidBody.velocity = new Vector2(0, 4f);
			didFlap = false;
		}
	}

	void MoveBird() {
		Vector3 temp = transform.position;
		temp.x += forwardSpeed * Time.deltaTime;
		transform.position = temp;
	}

	void SetCamerasX() {
		

	}

	public float GetPositionX() {
		return this.transform.position.x;
	}
}
