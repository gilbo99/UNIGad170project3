using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : Interactable
{
    public GameObject Bridges;
    private bool BridgeOpen;
    
    // This function will override interactables and use it here
    protected override void Interact()
    {

        //this was my first interact script but it wasnt meeting the LO but i still used it for thef first two buttons
        BridgeOpen = !BridgeOpen;
        Bridges.GetComponent<Animator>().SetBool("isdown", BridgeOpen);
        
       
    }
}
