using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public float _speed = 6f;
    public float _turnSmoothTime = 0.2f;
    private float _turnSmoothVelocity;
    private float _speedSmoothVelocity;
    private float _currentSpeed;
    private float _speedSmoothTime = 0.1f;
    private Vector3 _movement;
    private Animator _animator;
    //private Rigidbody _playerRb;
    private Transform _cameraTransform;
        
    void Awake()
    {
        _animator = GetComponent<Animator>();
        //_playerRb = GetComponent<Rigidbody>();
        _cameraTransform = Camera.main.transform;

        //DontDestroyOnLoad(gameObject);
        //if (FindObjectsOfType(GetType()).Length > 1)
        //{
        //    Destroy(gameObject);
        //}
    }

    
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void LateUpdate()
    {

    }

    void Animating(float h, float v)
    {
        bool walking = h != 0f || v != 0f;
        _animator.SetBool("isWalking", walking);
    }
    

    private void Move()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 inputDir = input.normalized;

        if (inputDir != Vector2.zero)
        {
            float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + _cameraTransform.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref _turnSmoothVelocity, _turnSmoothTime);
        }

        float targetSpeed = _speed * inputDir.magnitude;
        _currentSpeed = Mathf.SmoothDamp(_currentSpeed, targetSpeed, ref _speedSmoothVelocity, _speedSmoothTime);

        transform.Translate(transform.forward * _currentSpeed * Time.deltaTime, Space.World);

        Animating(input.x, input.y);
    }
}
