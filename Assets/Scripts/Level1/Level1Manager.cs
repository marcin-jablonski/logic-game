using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Level1Manager : LevelManager {

    private List<String> _correctOrder = new List<String>{
        "Block01", "Block02", "Block03", "Block04", "Block05", "Block06",
        "Block07", "Block08", "Block09","Block10", "Block11", "Block12",
        "Block13", "Block14", "Block15", "Block16", "Block17", "Block18"
    };

    private List<String> _playerOrder = new List<String>();

    public override void LogCollision(object oSender, EventArgs oEventArgs)
    {
        CollisionArgs oCollisionArgs = oEventArgs as CollisionArgs;
        addBlock(oCollisionArgs.ColliderChild.tag);
        //Debug.Log(oCollisionArgs.ColliderChild.tag);
        //oCollisionArgs.ColliderChild.gameObject.SetActive(false);
    }

    private void addBlock(String blockTag)
    {
       

        if (blockTag == _correctOrder.ElementAt(_playerOrder.Count))
        {
            Debug.Log("adding: " + blockTag);
            _playerOrder.Add(blockTag);
        }
        else
        {
            _playerOrder.Clear();
            Debug.Log("zle: "+ blockTag);
        }

  
        
    }


    // Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}
}
