﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookHandler {

    private static string lastScene = "MainMenu"; //change to menu

    public void handleBook()
    {
        if (SceneManager.GetActiveScene().name != "Book")
        {
            lastScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Book");
        }
        else
        {
            if (!string.IsNullOrEmpty(lastScene))
                SceneManager.LoadScene(lastScene);
        }
    }
}
