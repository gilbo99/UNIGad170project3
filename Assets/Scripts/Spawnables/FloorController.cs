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

    void TriggerTimerEvent()
    {
        time = 0f;
        EventBus.Current.KillFLoorTrigger();
        
    }

    void SetRandomTime()
    {
        TriggerTime = Random.Range(MinTime, MaxTime);
    }
}

