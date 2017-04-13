using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputListener : MonoBehaviour {

    public static Scene _lastLevel;
    public static string _tmp = "z";

    private float _curr = 0.0f;
    private float _delay = 0.2f;


    private void Awake()
    {
        //DontDestroyOnLoad(transform.gameObject);
    }

    private void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            handleBookButton(KeyCode.Return);
        }
    }

    //void OnGUI()
    //{
    //    Event e = Event.current;

    //    if (e.isKey)
    //    {

    //        if (Input.GetKeyUp(KeyCode.Return))
    //        {
    //            Debug.Log("Fine");
    //        }

    //        //if (Time.time > _curr)
    //        //{
    //        //    handleBookButton(e.keyCode);
    //        //}



    //            _curr = Time.time + _delay;
    //    }


    //    //if (e.isKey && e.keyCode == KeyCode.Space)
    //    //    Debug.Log("level: "+SceneManager.GetActiveScene().name);
    //}

    private void handleBookButton(KeyCode key)
    {

        //static Scene? lastLevel; 
        //Debug.Log("Val2: " + _tmp);
        if (key == KeyCode.Return)
        {
           
            if (SceneManager.GetActiveScene().name != "Book")
            {

                _lastLevel = SceneManager.GetActiveScene();
                _tmp = _lastLevel.name;
                Debug.Log("Val: " + _tmp);
                Debug.Log("saving: " + _lastLevel.name);
                SceneManager.LoadScene("Book");

            }
            else //tmp
            {
                if (_lastLevel != null)
                {
                    Debug.Log("trying to load: " + _tmp);
                    //Debug.Log("asd" + _tmp);
                    SceneManager.LoadScene(_tmp);
                }
                
                //SceneManager.LoadScene("Level1");
            }
        }
    }
}
