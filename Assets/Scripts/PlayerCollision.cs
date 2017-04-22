using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //private Rigidbody _playerRb;
    //public GameObject _player;
    public Level1Manager _level1Manager; //change to LevelManager

    public delegate void CollisionDelegate(object oSender, EventArgs oEventArgs);
    public event CollisionDelegate CollisionDetected;

    public void Collision(string player, string collider)
    {
        CollisionArgs oCollisionArgs = new CollisionArgs(player, collider);
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
        //this.CollisionDetected += _level1Manager.LogCollision;
        //_playerRb =  GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Block01"))
        {
            Collision("a", "Block01");
            //Debug.Log("Block01");
        }
        if (other.gameObject.CompareTag("Block02"))
        {
            Collision("b", "Block02");
            //Debug.Log("Block02");
        }
    }

    void Update () {
		
	}
}
