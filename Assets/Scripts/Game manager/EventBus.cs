using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    private static EventBus _current;
    //Makes an Event 
    public bool Tutorial1 = true;
    public bool Tutorial2 = true;
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

    public event Action UnSub;
    public void UnSubTrigger()
    {
        UnSub();
    }

    public event Action haveTutorial1;
    public void haveTutorial1Trigger()
    {
        Tutorial1 = !Tutorial1;
    }

    public event Action haveTutorial2;
    public void haveTutorial2Trigger()
    {
      Tutorial2 = !Tutorial2;
    }

    public event Action ReturnTutorial1;
    public bool ReturnTutorial1Trigger()
    {
        return Tutorial1;
    }
    public event Action ReturnTutorial2;
    public bool ReturnTutorial2Trigger()
    {
        return Tutorial2;
    }
 

}
