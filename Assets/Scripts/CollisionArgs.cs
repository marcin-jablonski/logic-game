using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArgs : EventArgs {

    public Collider ColliderParent { get; set; }
    public Collider ColliderChild { get; set; }

    public CollisionArgs(Collider colliderParent, Collider colliderChild)
    {
        ColliderParent = colliderParent;
        ColliderChild = colliderChild;
    }

}
