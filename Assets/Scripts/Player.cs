using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	public float speed;
	Animator anim;

	private Rigidbody2D rigid2D;

	void Start () {

		rigid2D = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}


	void FixedUpdate ()
	{

		Vector3 moveVector = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"), 4096) * speed;

		if (moveVector.x != 0 && moveVector.y != 0) {
			transform.rotation = Quaternion.LookRotation (moveVector, Vector3.back);
		}

		rigid2D.AddForce(moveVector);

	}

	void Update () {

		if (CrossPlatformInputManager.GetButtonDown("Swing")) {
			anim.SetTrigger("Attack");
		}
			
	}



}
