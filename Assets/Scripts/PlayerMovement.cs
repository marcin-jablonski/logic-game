using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float _speed = 6f;
    private Vector3 _movement;
    private Animator _animator;
    private Rigidbody _playerRb;
    private float camRayLength = 100f;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
        Turning();
        Animating(h, v);
    }

    void Move(float h, float v)
    {
        _movement.Set(h, 0f, v);
        _movement = _movement.normalized * _speed * Time.deltaTime;

        _playerRb.MovePosition(transform.position + _movement);
    }

    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 playerToMouse = camRay.direction * 10 - transform.position;
        playerToMouse.y = 0f;

        Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
        _playerRb.MoveRotation(newRotation);
    }

    void Animating(float h, float v)
    {
        bool walking = h != 0f || v != 0f;
        _animator.SetBool("isWalking", walking);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
