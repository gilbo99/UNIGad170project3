using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{

    
    public string MessagePromptl;
   // Called the Template method pattern
    public void BaseInteract( )
    {
        Interact();
    }
  
    //make it so it cant be edited on this script
    protected virtual void Interact()
    {
        //Template function to be overridden by the subclasses
    }
}
