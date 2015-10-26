using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazzard;

	void Start (){
		spawnWaves ();
	}

	void spawnWaves () {
		Vector2 spawnPosition = new Vector2 ();
		Quaternion spawnRotation = new Quaternion();
		Instantiate (hazzard, spawnPosition, spawnRotation);
	}

}
