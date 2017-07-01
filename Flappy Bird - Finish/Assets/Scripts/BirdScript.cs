using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {


	[SerializeField]
	private float forwardSpeed = 7f;
	[SerializeField]
	private Rigidbody2D myRigidBody;
	[SerializeField]
	private Animator anim;

	public static BirdScript instance;

	#region For debugging
	[SerializeField]
	private bool floatBird = false;

	#endregion
	
	void Awake() {
		if (instance == null) {
			instance = this;
		}

		#region For debugging only
			if (floatBird) {
				myRigidBody.isKinematic = true;
				myRigidBody.bodyType = RigidbodyType2D.Kinematic;
			}
		#endregion

    }
	// Use this for initialization
	void Start () {
		
	}
	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	void OnCollisionEnter2D(Collision2D other)
	{
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
		{
			didFlap = true;
		}
	}
	
	private bool didFlap = false;
	void FixedUpdate() {
		
		MoveBird();
		if (didFlap)
		{
			// myRigidBody.velocity = new Vector2(0, 4f);
			Debug.Log("Flapping...");
			anim.SetTrigger("Flap");
			didFlap = false;
		}
	}

	void MoveBird() {
		Vector3 temp = transform.position;
		temp.x += forwardSpeed * Time.deltaTime;
		transform.position = temp;
	}

	public float GetPositionX() {
		return this.transform.position.x;
	}
}
