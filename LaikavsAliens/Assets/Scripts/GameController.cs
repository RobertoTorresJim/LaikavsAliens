using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazzard;
	public float x;
	public float y;
	public Vector2 position;

	void Start (){
		spawnWaves ();
	}

	void spawnWaves () {
		Vector2 spawnPosition = new Vector2 ();
		position = new Vector2 (x, y);
		Quaternion spawnRotation = new Quaternion();
		//en caso orginial usar spawnPosition en lugar de position
		Instantiate (hazzard, position, spawnRotation);
	}

}
