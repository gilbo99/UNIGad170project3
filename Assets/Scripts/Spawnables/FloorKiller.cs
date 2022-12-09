using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorKiller : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.KillFLoor += Immaterialise;
        audioSource = GetComponent<AudioSource>();
    }

    void Immaterialise()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<MeshRenderer>().enabled;
        gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
        audioSource.Play();
        
    }



   void OnDestroy() {
        EventBus.Current.KillFLoor -= Immaterialise;
    }
   
}
