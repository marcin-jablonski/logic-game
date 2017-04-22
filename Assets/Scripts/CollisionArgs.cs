using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArgs : EventArgs {

    public string Player { get; set; }
    public string Collider { get; set; }

    public CollisionArgs(string player, string collider)
    {
        Player = player;
        Collider = collider;
    }

}
