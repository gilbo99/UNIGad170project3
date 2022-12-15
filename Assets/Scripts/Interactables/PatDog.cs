using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PatDog : MonoBehaviour
{   
    public GameObject Dog;
    private bool Playercanpat;
    private bool starttimer;
    public string useKey;
    public TextMeshProUGUI playertext;
    public float Timer = 0.0f;
    
    
    void Update()
    {
        if(Playercanpat && Input.GetKeyDown("e"))
        {
            starttimer = true;
            Dog.GetComponent<Animator>().SetBool("Patting", starttimer);
            Timer = 1.5f;
            Playercanpat = false;   
        }

        if(starttimer && Timer <= 0f)
        {
            starttimer = false;
            Dog.GetComponent<Animator>().SetBool("Patting", starttimer);
            Timer = 0f;
            
        }
    }

    // by putting the timer in FixedUpdate it counts down correctly 
    void FixedUpdate()
    {
        Timer -= Time.deltaTime;
    }


    //changes the text and make it that players are able to press e and when they leave they cant
    void OnTriggerEnter()
    {
        Playercanpat = true;
        playertext.text = useKey;
        
    } 

    void OnTriggerExit()
    {
        Playercanpat = false;
        playertext.text = "";
    }
}
