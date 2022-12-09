using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    private static EventBus _current;
    //Makes an Event 
    private int HowmanyTutorial = 0;
    private int totalTutorials = 2;
    public static EventBus Current { get { return _current; } }
   

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    public event Action KillFLoor;
    public void KillFLoorTrigger()
    {
        KillFLoor();
    }

    // public increase function number by one
    public void SetTutorialDone()
    {
        HowmanyTutorial++;
    }
    // return function number

    public bool ReturnTutorialStatus()
    {
        return HowmanyTutorial != totalTutorials;
    }

    
 

}
