using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : LevelManager {

    public override void LogCollision(object oSender, EventArgs oEventArgs)
    {
        CollisionArgs oCollisionArgs = oEventArgs as CollisionArgs;
        Debug.Log(oCollisionArgs.ColliderChild.tag);
    }

    //public void LogCollision(object oSender, EventArgs oEventArgs)
    //{
    //    CollisionArgs oCollisionArgs = oEventArgs as CollisionArgs;

    //    Debug.Log(oCollisionArgs.ColliderParent.tag);
    //}

    // Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}
}
