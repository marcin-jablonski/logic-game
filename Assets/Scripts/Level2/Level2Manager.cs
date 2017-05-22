using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Manager : LevelManager {

    public Text winText;

    private Dictionary<String, PositionDirection> _currentPositions;
    private GameObject _player = null;

    public override void LogCollision(object oSender, EventArgs oEventArgs)
    {
        //not necessary
    }


    private void rotateStatue(GameObject statue)
    {
        Debug.Log(statue.name);
        StatueRotator rotator = statue.GetComponent<StatueRotator>();
        rotator.changeRotation();
        _currentPositions[rotator.name] = rotator.getCurrentDirection();
    }


    private GameObject FindClosestStatue()
    {
        List <GameObject> gos = new List<GameObject>();
        gos.Add(GameObject.FindGameObjectWithTag("BearStatue"));
        gos.Add(GameObject.FindGameObjectWithTag("LionStatue"));
        gos.Add(GameObject.FindGameObjectWithTag("HorseStatue"));
        gos.Add(GameObject.FindGameObjectWithTag("DragonStatue"));
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = _player.transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }


    private void detectStatue()
    {
        GameObject closestStatue = FindClosestStatue();
        Vector3 diff = closestStatue.transform.position - _player.transform.position;

        if (diff.sqrMagnitude <= 5.5f)
        {
            Debug.Log("close to "+closestStatue.name);

            if (Input.GetKeyUp("space"))
            {
                rotateStatue(closestStatue);
            }
                

        }


    }

    private void checkPositions()
    {
        if (_currentPositions["BearStatue"]==PositionDirection.North &&
            _currentPositions["LionStatue"] == PositionDirection.North &&
            _currentPositions["HorseStatue"] == PositionDirection.South &&
            _currentPositions["DragonStatue"] == PositionDirection.South)
        {
            winText.text = "Zwycięstwo";
        }
    }


    void Start () {
        _player = GameObject.FindGameObjectWithTag("Player");
        _currentPositions = new Dictionary<String, PositionDirection>();
        //tmp -> move to const (StatueRotator uses the same data)
        _currentPositions.Add("BearStatue", PositionDirection.South);
        _currentPositions.Add("LionStatue", PositionDirection.North);
        _currentPositions.Add("HorseStatue", PositionDirection.West);
        _currentPositions.Add("DragonStatue", PositionDirection.East);
    }

    // Update is called once per frame
    void Update(){
        detectStatue();
        checkPositions();
    }

}
