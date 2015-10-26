using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.velocity = transform.right*speed;
	}

}
