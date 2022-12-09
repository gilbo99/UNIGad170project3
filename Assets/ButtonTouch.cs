using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTouch : MonoBehaviour
{
    private bool playercanclick = false;
    public GameObject Gas;
    
    void Update()
    {
        if(playercanclick && Input.GetKeyDown("e"))
        {
            Gas.SetActive(false);
            
        }
    }
   
   
    void OnTriggerEnter()
    {
        playercanclick = true;
    } 

    void OnTriggerExit()
    {
        playercanclick = false;
    }
}
