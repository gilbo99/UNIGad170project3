using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    public float MaxTime = 10f;
    public float MinTime = 5f;
    public float time = 0f;
    public float TriggerTime;
    

    void FixedUpdate()
    {
        
        time += Time.deltaTime;
        
        if(time >= TriggerTime)
        {
            TriggerTimerEvent();
            SetRandomTime();
        }
    }
    //one the timer has finished EventBus is Trigger 
    void TriggerTimerEvent()
    {
        time = 0f;
        EventBus.Current.KillFLoorTrigger();
        
    }
    // sets a random time between MinTime and MaxTime
    void SetRandomTime()
    {
        TriggerTime = Random.Range(MinTime, MaxTime);
    }
}

