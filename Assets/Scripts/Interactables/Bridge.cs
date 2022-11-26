using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : Interactable
{
    // Start is called before the first frame update
    public GameObject Bridges;
    private bool BridgeOpen;
    
    
    // This function will override interactables and use it here
    protected override void Interact()
    {
        BridgeOpen = !BridgeOpen;
        Bridges.GetComponent<Animator>().SetBool("isdown", BridgeOpen);
        
       
    }
}
