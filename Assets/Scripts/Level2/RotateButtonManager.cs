using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class RotateButtonManager : MonoBehaviour {

	private GameObject rotateButton;

	// Use this for initialization
	void Start () {
		rotateButton = SceneManager.GetActiveScene ().GetRootGameObjects () [2];
		rotateButton.SetActive (false);
	}

	void OnTriggerEnter(Collider other) {
		rotateButton.SetActive(true);
		Debug.Log (rotateButton.activeSelf);
	}

	void OnTriggerExit(Collider other) {
		rotateButton.SetActive(false);
	}
}
