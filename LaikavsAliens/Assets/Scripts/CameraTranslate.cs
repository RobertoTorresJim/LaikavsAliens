using UnityEngine;
using System.Collections;

public class CameraTranslate : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector2 (.5f, 0) * Time.deltaTime);	
	}


}
