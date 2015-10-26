using UnityEngine;
using System.Collections;
using UnityEngine.UI;

<<<<<<< HEAD
[System.Serializable]//this make visible the variables of the class in another class
//class that instanciate the variables for the frame of the camera
public class Boundary{
	public float xMin, xMax, yMin, yMax;

}

public class Lk_Control : MonoBehaviour {
	//speed and rigidbody of the Laika spaceship
	public float speed;
	public Rigidbody2D rb;
	//make the minimum and maximum of the vaues that can take the ship for doesn't go outside of
	//the camera frame
	public Boundary boundary;
	//instanciate of the basic shoots of laika
	public GameObject shot;
	public Transform shotSpawn;
	
	public float fireRate;
	private float nextFire; 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	void Update(){
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
//			GameObject clone = 
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // as GameObject;
		}
	}

=======
public class Lk_Control : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	
	}
>>>>>>> 1a53831ace3a1104514f5c540c234eb4ad435092
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
<<<<<<< HEAD

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.velocity = movement * speed;

		rb.position = new Vector2 (
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp (rb.position.y, boundary.yMin, boundary.yMax)
		);
=======
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.AddForce (movement * speed);

>>>>>>> 1a53831ace3a1104514f5c540c234eb4ad435092
	}
}
