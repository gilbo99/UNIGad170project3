using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_trigger : MonoBehaviour
{
   public GameObject TutorialScreen;
   public GameObject Player;

   void OnTriggerEnter(Collider collider)
   {
        StartTutorial();
   }


   void StartTutorial()
   {
       // TutorialScreen.gameObject.SetActive(false);
        //Player.GetComponent<PlayerMovement>().enabled = false;
   }

   void Update()
   {
    
   }
}
