using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class Level1Manager : LevelManager {

    private List<String> _correctOrder = new List<String>{
        "Block01", "Block02", "Block03", "Block04", "Block05", "Block06",
        "Block07", "Block08", "Block09", "Block10", "Block11", "Block12",
        "Block13", "Block14", "Block15", "Block16", "Block17", "Block18"
    };

    private List<Collider> _playerOrder = new List<Collider>();

    public Text winText;

    public override void LogCollision(object oSender, EventArgs oEventArgs)
    {
        CollisionArgs oCollisionArgs = oEventArgs as CollisionArgs;
        addBlock(oCollisionArgs.ColliderChild);
    }

    private void addBlock(Collider block)
    {

        if (block.tag == _correctOrder.ElementAt(_playerOrder.Count))
        {
            Debug.Log("adding: " + block.tag);
            _playerOrder.Add(block);
            block.gameObject.SetActive(false);
            if (_correctOrder.Count == _playerOrder.Count)
            {
                winText.text = "Zwycięstwo";
                SceneManager.LoadScene("Level2");
            }
                
        }
        else
        {
            foreach (Collider val in _playerOrder)
            {
                val.gameObject.SetActive(true);
            }
            _playerOrder.Clear();
            Debug.Log("zle: " + block.tag);
        }
  
    }

    // Use this for initialization
    //void Start () {

    //}

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        //DontDestroyOnLoad(transform.root.gameObject);
        //if (FindObjectsOfType(GetType()).Length > 1)
        //{
        //    Destroy(gameObject);
        //}
        //foreach (Collider val in _playerOrder)
        //{
        //    val.gameObject.SetActive(false);
        //    Debug.Log("wtf: " + val.tag);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("trololo");
        //foreach (Collider val in _playerOrder)
        //{
        //    val.gameObject.SetActive(false);
        //    Debug.Log("wtf: " + val.tag);
        //}
    }
}
