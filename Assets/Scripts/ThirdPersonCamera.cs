using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public Transform _target;
    public float _dstFromTarget = 4;

    private float _mouseSensitivity = 10;
    private Vector2 _pitchMinMax = new Vector2(-40, 85);
    private float _rotationSmoothTime = 0.12f;
    private Vector3 _rotationSmoothVelocity;
    private Vector3 _currentRotation;
    private float _yaw;
    private float _pitch;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        _yaw += Input.GetAxis("Mouse X") * _mouseSensitivity;
        _pitch += -Input.GetAxis("Mouse Y") * _mouseSensitivity;
        _pitch = Mathf.Clamp(_pitch, _pitchMinMax.x, _pitchMinMax.y);

        Vector3 targetRotation = new Vector3(_pitch, _yaw);
        _currentRotation = Vector3.SmoothDamp(_currentRotation, targetRotation, ref _rotationSmoothVelocity, _rotationSmoothTime);
       
        transform.eulerAngles = _currentRotation;
        transform.position = _target.position - transform.forward * _dstFromTarget;
    }
}
