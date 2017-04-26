using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelManager : MonoBehaviour {
    //info-> abstract bo nie da sie uzywac w unity interfejsow widocznych w Inspektorze
    public abstract void LogCollision(object oSender, EventArgs oEventArgs);

}
