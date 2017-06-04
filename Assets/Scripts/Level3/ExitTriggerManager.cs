using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTriggerManager : MonoBehaviour {
	private static int _numberOfTries = 0;
	void OnTriggerEnter(Collider other) {
		if (name == "NorthCollider") {
			Debug.Log ("Win!");
			GameObject.Find ("LevelManager").GetComponent<Level3Manager> ().NotifyWin ();
		} else {
			_numberOfTries++;
			//show info about wrong exit for 5s && teleport back?
		}
	}
}
