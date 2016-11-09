using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public float speed;
	public Transform player;

	private Rigidbody2D rigid2D;

	void Start () {

		rigid2D = GetComponent<Rigidbody2D>();

	}

	void FixedUpdate () {

		float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y), 
			(player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;

		transform.eulerAngles = new Vector3 (0, 0, z);
		rigid2D.AddForce(gameObject.transform.up * speed);

	}

}
