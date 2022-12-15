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
    

    void Update()
    {   
        // if time = 1 it sets time to 0 and it becomes true 
        time += Time.deltaTime;
        if(ingas && time >= TimeTaken)
        {
        // sends damaged to player 
        Temp.GetComponent<PlayerStats>().TakeDamaged(Damaged);
        time = 0;
        }
    }
  
  // enables and disable the gas to deal damaged 
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
