using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    private Rigidbody _playerRb;

    void Start () {
        _playerRb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Block01"))
        {
            Debug.Log("Block01");
        }
        if (other.gameObject.CompareTag("Block02"))
        {
            Debug.Log("Block02");
        }
    }

    void Update () {
		
	}
}
