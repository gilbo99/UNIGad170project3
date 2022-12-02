using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorKiller : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.KillFLoor += destroy;
        EventBus.Current.UnSub += localUnsub;

       
    }
    void destroy()
    {
       gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<MeshRenderer>().enabled;
       gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
      
    }
    void localUnsub()
    {
        EventBus.Current.KillFLoor -= destroy;
        EventBus.Current.UnSub -= localUnsub;
    }

   
   
}
