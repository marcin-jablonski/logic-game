using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour {

    private Book _book;

    void Awake()
    {
        _book = GetComponent<Book>();

        if (GameManager.instance != null)
        {
            _book.currentPage = GameManager.instance.CurrBookPage;
        }
    }
	
	void Update () {

       if (GameManager.instance != null)
       {
            GameManager.instance.CurrBookPage = _book.currentPage;
        }
        
	}
}
