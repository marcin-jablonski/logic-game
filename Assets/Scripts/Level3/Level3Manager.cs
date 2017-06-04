using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3Manager : MonoBehaviour {

	public Text WinText;
	public void NotifyWin() {
		WinText.text = "Zwycięstwo!";
	}
}
