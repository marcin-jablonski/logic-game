using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    private int _currBookPage = 4;
    //private float Hp;
    //private int level = 1; 

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        InitGame();
    }

    void InitGame()
    {

    }

    public int CurrBookPage
    {
        get { return _currBookPage; }
        set
        {
            if (value % 2 == 0)
            {
                _currBookPage = value;
            }
        }
    }

    //public void SetCurrBookPage(int page)
    //{
    //    _currBookPage = page;
    //}

    //public int GetCurrBookPage()
    //{
    //    return _currBookPage;
    //}

    private void Update()
    {
        Debug.Log("page: " + _currBookPage);
    }

}
