using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputListener : MonoBehaviour {


    private void LateUpdate()
    {
        KeysActions();
    }
    
    private void KeysActions()
    {
		if (Input.GetKeyUp (KeyCode.Return)) {
			handleBookKey ();
		} else if (Input.GetKeyUp (KeyCode.Escape)) {
			handleEscapeKey();
		}
    }

    private void handleBookKey()
    {
        GameObject book = GameObject.FindGameObjectWithTag("Book");
        Canvas bookCanvas = book.GetComponent<Canvas>();
        if (bookCanvas.enabled)
        {
            bookCanvas.enabled = false;
        }
        else
        {
            bookCanvas.enabled = true;
        }
    }

	private void handleEscapeKey()
	{
		//SceneManager.LoadScene("MainMenu");
	}
}
