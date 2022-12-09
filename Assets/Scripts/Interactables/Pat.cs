using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pat : Interactable
{

    public GameObject Dog;
    private bool Playerpat;
    public float Timer = 0.0f;
    
  // was the first Interactable i used that uses rays so i changed it
    

    
    void Update()
    {   
        Timer -= Time.deltaTime;
        if(Timer <= 0f && Playerpat)
        {
            Playerpat = false;
            Dog.GetComponent<Animator>().SetBool("pats", Playerpat);
        }
    }

    protected override void Interact()
    {
       
        Playerpat = !Playerpat;
        Dog.GetComponent<Animator>().SetBool("pats", Playerpat);
        Timer = 1.5f;
        
        
       
    }
}
