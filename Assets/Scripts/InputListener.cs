using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputListener : MonoBehaviour {


    private void LateUpdate()
    {
        KeysActions();
    }
    
    private void KeysActions()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            handleBookKey();
        }
    }

    private void handleBookKey()
    {
        BookHandler book = new BookHandler();
        book.handleBook();
    }
}
