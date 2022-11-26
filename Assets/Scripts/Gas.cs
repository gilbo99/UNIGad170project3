using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    private bool ingas;
    private Collider Temp;
    public float Damaged = 20;
    float time;
    public float TimeTaken = 1;
    void Start()
    {
        
    }

    void Update()
    {   
        time += Time.deltaTime;
        if(ingas && time >= TimeTaken)
        {
        Temp.GetComponent<PlayerStats>().TakeDamaged(Damaged);
        time = 0;
        }
    }
  
  
   void OnTriggerEnter(Collider other)
    {
        Temp = other;
        ingas = true;
        
    }

    void OnTriggerExit(Collider other)
    {
        
         ingas = false;
    }


     
}
