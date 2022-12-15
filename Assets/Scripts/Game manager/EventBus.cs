using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    // Make it static so it can be Access anywhere
    private static EventBus _current;
    
    private int HowmanyTutorial = 0;
    [SerializeField] int totalTutorials = 3;
    public static EventBus Current { get { return _current; } }
   
    // looks to see if theres not already a event bus if there is it Destroy itself
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
    
    //Makes an Event so it can get called 
    public event Action KillFLoor;
    // is the Event trigger 
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
    
    public event Action SwitchGasButtons;
    public void SwitchGasButtonsTrigger()
    {
        SwitchGasButtons();
    }


    
 

}
