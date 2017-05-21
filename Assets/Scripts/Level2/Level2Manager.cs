using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Manager : LevelManager {

    public Text winText;

    public override void LogCollision(object oSender, EventArgs oEventArgs)
    {
        CollisionArgs oCollisionArgs = oEventArgs as CollisionArgs;
        rotateStatue(oCollisionArgs.ColliderChild);
    }


    private void rotateStatue(Collider statue)
    {
        Debug.Log(statue.name);
        statue.gameObject.GetComponent<StatueRotator>().changeRotation();

    }

        // Use this for initialization
        // void Start () {

        //}

        // Update is called once per frame
        void Update () {
		
	}
}
