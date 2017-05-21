using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueRotator : MonoBehaviour {

    private float _currentRotation = 0.0f;


    public void changeRotation()
    {
        _currentRotation += 90.0f;
    }

	void Start () {
		
	}

    private void rotate()
    {
        float speed = 0.5f;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, _currentRotation, 0), Time.deltaTime * speed);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 180, 0), Time.deltaTime * 10f);
    }

    // Update is called once per frame
    void Update () {
        rotate();
    }
}
