using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Manager : LevelManager {

    public Text winText;

    private GameObject _player = null;

    public override void LogCollision(object oSender, EventArgs oEventArgs)
    {
        CollisionArgs oCollisionArgs = oEventArgs as CollisionArgs;
        //rotateStatue(oCollisionArgs.ColliderChild);
        //detectStatue(oCollisionArgs.ColliderParent,oCollisionArgs.ColliderChild);
    }


    private void rotateStatue(GameObject statue)
    {
        Debug.Log(statue.name);
        statue.GetComponent<StatueRotator>().changeRotation();

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

        if (diff.sqrMagnitude <= 2.0f)
        {
            Debug.Log("close to "+closestStatue.name);

            if (Input.GetKeyUp("space"))
            {
                rotateStatue(closestStatue);
            }
                

        }


    }


    //private void LateUpdate()
    //{
    //    KeysActions();
    //}

    //private void KeysActions()
    //{
    //    if (Input.GetKeyUp(KeyCode.Return))
    //    {
    //        handleBookKey();
    //    }
    //    else if (Input.GetKeyUp(KeyCode.Escape))
    //    {
    //        handleEscapeKey();
    //    }
    //}


    void Start () {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
        {
            detectStatue();
        }

}
