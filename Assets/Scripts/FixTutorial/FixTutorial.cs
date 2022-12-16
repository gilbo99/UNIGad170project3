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
   
     
    //before the game starts this runs ans asked the EventBus if the Tutorial are finished 
    void Start()
    {
        TutorialNumb = EventBus.Current.ReturnTutorialStatus();
        

    }

    // starts Tutorial when you walk in
    private void OnTriggerEnter(Collider collider)
    {
          
        StartTutorial();
          
    }



    private void StartTutorial()
    {
        if(TutorialNumb)
        {
            /*
            starts a timer so the Tutorial will stay up for a certan amount of time
            sets all the text
            disables PlayerMovement script
            tells EventBus that it has done one Tutorial
            */
            Timer = 2.0f;
            Title.text = TitleSave;
            Description.text = DescriptionSave;     
            TutorialScreen.gameObject.SetActive(true);
            Player.GetComponent<PlayerMovement>().enabled = false;
            FinishedTutorial = true;
            EventBus.Current.SetTutorialDone();
        }  
    }
    private void FixedUpdate()
    {
        Timer -= Time.deltaTime;
    }
    
    private void Update()
    {
        /*
        time - time taken
        if any key is pressed and time has passed set time 
        enables PlayerMovement and disables Tutorial
        */
        if(Input.anyKey && Timer <= 0 && FinishedTutorial)
        {
            TutorialScreen.gameObject.SetActive(false);
            Player.GetComponent<PlayerMovement>().enabled = true;
            gameObject.SetActive(false);
            FinishedTutorial = false;
        }
    }    
}
