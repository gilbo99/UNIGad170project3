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
    void Update()
    {
        if(playercanclick && Input.GetKeyDown("e"))
        {
           EventBus.Current.SwitchGasButtonsTrigger();  
        }
    }

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
