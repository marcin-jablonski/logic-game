using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueRotator : MonoBehaviour {

    private float _currentRotation = 0.0f;

    //private float _xRotation = 0.0f;

    public void changeRotation()
    {
        if (System.Math.Round((decimal)transform.rotation.eulerAngles.y, 0) % 90 == 0)
        {
            _currentRotation = (_currentRotation + 90.0f) % 360;
            if (_currentRotation < 0) _currentRotation += 360;
        }

    }

	void Awake () {
        //Transform go = GetComponent<Transform>();
        //_xRotation = go.rotation.x;
        //Debug.Log("X rotation: " + transform.rotation.x);
	}


    private void rotate()
    {
        float speed = 0.5f;
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(_xRotation, _currentRotation, transform.rotation.z), Time.deltaTime * speed);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(transform.rotation.eulerAngles.x, _currentRotation, transform.rotation.eulerAngles.z), Time.deltaTime * 20f);
      
        
    }

    // Update is called once per frame
    void Update () {
        rotate();
    }
}
