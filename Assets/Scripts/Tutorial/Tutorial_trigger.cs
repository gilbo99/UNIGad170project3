using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial_trigger : MonoBehaviour
{
   [SerializeField] GameObject TutorialScreen;
   [SerializeField] GameObject Player;
   private float Timer = 0.0f;
   public bool one;
   private bool StartedTutorial = true; 
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
         /* if(EventBus.Current.ReturnTutorial1Trigger())
          {
               Timer = 2.0f;
               Title.text = TitleSave;
               Description.text = DescriptionSave;     
               TutorialScreen.gameObject.SetActive(true);
               Player.GetComponent<PlayerMovement>().enabled = false;
               StartedTutorial = true;
        
               

               
             
          }
        
        */
        if(EventBus.Current.ReturnTutorialStatus())
        {
            StartedTutorial = false;
            Timer = 2.0f;
            Title.text = TitleSave;
            Description.text = DescriptionSave;     
            TutorialScreen.gameObject.SetActive(true);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }       
     }

     private void Update()
     {

          Timer -= Time.deltaTime;
          if(Input.anyKey && Timer <= 0 && StartedTutorial)
          {
               
               TutorialScreen.gameObject.SetActive(false);
               Player.GetComponent<PlayerMovement>().enabled = true;
               StartedTutorial = false;
               
          }
     }

     // When the tutorial is done trigger the SetTutorialDone function
    
}
