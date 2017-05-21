using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueRotator : MonoBehaviour {

    private float _currentRotation = 0.0f;
    private PositionDirection _currentDirection;

    private void Awake()
    {
        _currentRotation = transform.rotation.eulerAngles.y;

        switch (name)
        {
            case "BearStatue":
                _currentDirection = PositionDirection.South;
                break;
            case "LionStatue":
                _currentDirection = PositionDirection.North;
                break;
            case "HorseStatue":
                _currentDirection = PositionDirection.West;
                break;
            case "DragonStatue":
                _currentDirection = PositionDirection.East;
                break;

            default:
                Debug.Log("Statue not found");
                break;
        }


    }

    public PositionDirection getCurrentDirection()
    {
        return _currentDirection;
    }


    public void changeRotation()
    {

        if (System.Math.Round((decimal)transform.rotation.eulerAngles.y, 0) % 90 == 0)
        {
            _currentRotation = (_currentRotation + 90.0f) % 360;
            if (_currentRotation < 0) _currentRotation += 360;

            _currentDirection = (PositionDirection)(((int)_currentDirection + 1) % 4);
        }

    }


    private void rotate()
    {
        float speed = 0.5f;
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(_xRotation, _currentRotation, transform.rotation.z), Time.deltaTime * speed);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(
            transform.rotation.eulerAngles.x, 
            _currentRotation, 
            transform.rotation.eulerAngles.z),
            Time.deltaTime * 20f);
        
       
    }

    // Update is called once per frame
    void Update () {
        rotate();
    }
}
