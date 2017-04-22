using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //private Rigidbody _playerRb;
    //public GameObject _player;
    public LevelManager _levelManager;

    public delegate void CollisionDelegate(object oSender, EventArgs oEventArgs);
    public event CollisionDelegate CollisionDetected;

    public void Collision(Collider parent, Collider child)
    {
        CollisionArgs oCollisionArgs = new CollisionArgs(parent, child);
        FireCollisionEvent(oCollisionArgs);
    }

    public void FireCollisionEvent(EventArgs oEventArgs)
    {
        if (CollisionDetected != null)
        {
            CollisionDetected(this, oEventArgs);
        }
    }

    void Start () {
        this.CollisionDetected += _levelManager.LogCollision;
        //_playerRb =  GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Collision(this.GetComponent<Collider>(), other);
    }

    void Update () {
		
	}
}
