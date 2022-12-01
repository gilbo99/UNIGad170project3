using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial_Health_trigger : MonoBehaviour
{
   [SerializeField] GameObject TutorialScreen;
   [SerializeField] GameObject Player;
   private bool hasEntered;
   private float Timer = 0.0f;
   [SerializeField] TextMeshProUGUI Title;
   [SerializeField] TextMeshProUGUI Description;
   [SerializeField] string TitleSave;   
   [SerializeField] string DescriptionSave;
    
    
    private void OnTriggerEnter(Collider collider)
    {
        StartTutorial();
        
    }



    private void StartTutorial()
    {
        if(hasEntered == false)
        {
            Timer = 2.0f;
            Title.text = TitleSave;
            Description.text = DescriptionSave;     
            TutorialScreen.gameObject.SetActive(true);
            Player.GetComponent<PlayerMovement>().enabled = false;
            hasEntered = true;
            
        }
        
    }

    private void Update()
    {

        Timer -= Time.deltaTime;
        if(Input.anyKey && hasEntered == true && Timer <= 0)
        {
               
            TutorialScreen.gameObject.SetActive(false);
            Player.GetComponent<PlayerMovement>().enabled = true;
               
        }
    }
    
}