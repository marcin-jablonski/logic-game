using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class Level1Manager : LevelManager {

    private List<String> _correctOrder = new List<String>{
        "Block01y", "Block02r", "Block03r", "Block04r", "Block05r", "Block06b",
        "Block07b", "Block08b", "Block09g", "Block10g", "Block11g", "Block12g",
        "Block13b", "Block14b", "Block15r", "Block16r", "Block17r", "Block18x"
    };

    private List<Collider> _playerOrder = new List<Collider>();

    public Text winText;

    public override void LogCollision(object oSender, EventArgs oEventArgs)
    {
        CollisionArgs oCollisionArgs = oEventArgs as CollisionArgs;
        addBlock(oCollisionArgs.ColliderChild);
    }


    private int curr = 0;
    private String currBlock = "";
    private String nextBlock = "";

    private void addBlock(Collider block)
    {
        //Debug.Log("jo: "+block.tag[block.tag.Length-1]);

        if (block.tag == _correctOrder.ElementAt(curr) && _playerOrder.Count == curr)
        {
            currBlock = _correctOrder.ElementAt(curr);
            nextBlock = _correctOrder.ElementAt(++curr);
            //curr++;
            Debug.Log("current: " + currBlock);
            Debug.Log("next: " + nextBlock);

            block.gameObject.SetActive(false);
            _playerOrder.Add(block);

        }
        else if (curr>0 && block.tag[block.tag.Length - 1] == nextBlock[nextBlock.Length - 1])
        {
            Debug.Log("hiii");
            block.gameObject.SetActive(false);
            _playerOrder.Add(block);
        }
        else
        {
            foreach (Collider val in _playerOrder)
            {
                val.gameObject.SetActive(true);
            }
            _playerOrder.Clear();
            curr = 0;
            currBlock = "";
            nextBlock = "";
        }


        //if (block.tag == _correctOrder.ElementAt(_playerOrder.Count)
        //    || block.tag[block.tag.Length - 1] == _correctOrder.ElementAt(_playerOrder.Count)[_correctOrder.ElementAt(_playerOrder.Count).Length-1])

        //{
        //    Debug.Log("adding: " + block.tag);
        //    _playerOrder.Add(block);
        //    block.gameObject.SetActive(false);


        //    if (_correctOrder.Count == _playerOrder.Count)
        //    {
        //        winText.text = "Zwycięstwo";
        //        SceneManager.LoadScene("Level2");
        //    }

        //}

        //else
        //{
        //    foreach (Collider val in _playerOrder)
        //    {
        //        val.gameObject.SetActive(true);
        //    }
        //    _playerOrder.Clear();
        //    Debug.Log("zle: " + block.tag);
        //}


        //if (block.tag == _correctOrder.ElementAt(_playerOrder.Count))
        //{
        //    Debug.Log("adding: " + block.tag);
        //    _playerOrder.Add(block);
        //    block.gameObject.SetActive(false);
        //    if (_correctOrder.Count == _playerOrder.Count)
        //    {
        //        winText.text = "Zwycięstwo";
        //        SceneManager.LoadScene("Level2");
        //    }

        //}
        //else
        //{
        //    foreach (Collider val in _playerOrder)
        //    {
        //        val.gameObject.SetActive(true);
        //    }
        //    _playerOrder.Clear();
        //    Debug.Log("zle: " + block.tag);
        //}

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
