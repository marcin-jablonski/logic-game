using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelKeeper : MonoBehaviour {

    //TODO Change it somehow! (delete)
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

}
