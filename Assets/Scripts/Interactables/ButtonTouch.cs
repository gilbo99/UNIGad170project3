using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTouch : MonoBehaviour
{
    private bool playercanclick = false;
    public GameObject Gas;
    public TextMeshProUGUI playertext;
    public string useKey;

    //This is my interact script 
    void Update()
    {

        // when the player hits e it will tell the EventBus to trigger
        if(playercanclick && Input.GetKeyDown("e"))
        {
           EventBus.Current.SwitchGasButtonsTrigger();  
        }
    }


    //when the player enters the volume it sets a bool and unsets the bool when they leave
    void OnTriggerEnter()
    {
        playercanclick = true;
        playertext.text = useKey;
 
    } 

    void OnTriggerExit()
    {
        playercanclick = false;
        playertext.text = "";

    }
    
}
