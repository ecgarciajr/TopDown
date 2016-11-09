using UnityEngine;
using System.Collections;

public class PlayerMobility : MonoBehaviour {

	public float speed;
	Animator anim;

	private Rigidbody2D rigid2D;

	void Start () {

		rigid2D = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			anim.SetTrigger("Attack");
		}

	}

	void FixedUpdate ()
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);
		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		rigid2D.angularVelocity = 0;

		float input = Input.GetAxis ("Vertical");
		rigid2D.AddForce (gameObject.transform.up * speed * input);

	}


}
