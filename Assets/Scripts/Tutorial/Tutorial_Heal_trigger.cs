using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial_Heal_trigger : MonoBehaviour
{
   [SerializeField] GameObject TutorialScreen;
   [SerializeField] GameObject Player;
   private float Timer = 0.0f;
   public bool one;
   private bool FinishedTutorial; 
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
          if(EventBus.Current.ReturnTutorial2Trigger())
          {
               Timer = 2.0f;
               Title.text = TitleSave;
               Description.text = DescriptionSave;     
               TutorialScreen.gameObject.SetActive(true);
               Player.GetComponent<PlayerMovement>().enabled = false;
               FinishedTutorial = true;
               EventBus.Current.haveTutorial2Trigger();
               

               
             
          }

          
          
     }

     private void Update()
     {

          Timer -= Time.deltaTime;
          if(Input.anyKey && Timer <= 0 && FinishedTutorial)
          {
               
               TutorialScreen.gameObject.SetActive(false);
               Player.GetComponent<PlayerMovement>().enabled = true;
               FinishedTutorial = false;
               
          }
     }
    
}
