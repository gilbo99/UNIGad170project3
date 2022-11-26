using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : Interactable
{
    // Start is called before the first frame update
    public GameObject door;
    private bool doorOpen;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // This function will override interactables and use it here
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("isopen", doorOpen);
        
       
    }
}
