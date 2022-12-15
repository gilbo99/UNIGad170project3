using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : Interactable
{
    
    public GameObject door;
    private bool doorOpen;
    
   
    // This function will override interactables and use it here
    // uses the old Interact 
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("isopen", doorOpen);
        
       
    }
}
