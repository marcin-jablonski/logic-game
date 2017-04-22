using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour {



    public void LogCollision(object oSender, EventArgs oEventArgs)
    {
        CollisionArgs oCollisionArgs = oEventArgs as CollisionArgs;

        Debug.Log(oCollisionArgs.Collider);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
