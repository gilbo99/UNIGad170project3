using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FixTutorial : MonoBehaviour
{
    [SerializeField] GameObject TutorialScreen;
    [SerializeField] GameObject Player;
    private float Timer = 0.0f;
    private bool FinishedTutorial; 
    [SerializeField] TextMeshProUGUI Title;
    [SerializeField] TextMeshProUGUI Description;
    public string TitleSave;   
    public string DescriptionSave;
    private bool TutorialNumb;
   
     

    void Start()
    {
        TutorialNumb = EventBus.Current.ReturnTutorialStatus();
        

    }


    private void OnTriggerEnter(Collider collider)
    {
          
        StartTutorial();
          
    }



     private void StartTutorial()
     {
        if(TutorialNumb)
        {
            Timer = 2.0f;
            Title.text = TitleSave;
            Description.text = DescriptionSave;     
            TutorialScreen.gameObject.SetActive(true);
            Player.GetComponent<PlayerMovement>().enabled = false;
            FinishedTutorial = true;
            EventBus.Current.SetTutorialDone();
        }  
     }

     private void Update()
     {
          Timer -= Time.deltaTime;
          if(Input.anyKey && Timer <= 0 && FinishedTutorial)
          {
               TutorialScreen.gameObject.SetActive(false);
               Player.GetComponent<PlayerMovement>().enabled = true;
               gameObject.SetActive(false);
               FinishedTutorial = false;
          }
     }    
}
