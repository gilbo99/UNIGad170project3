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

    // Update is called once per frame
    void FixedUpdate()
    {
        Timer -= Time.deltaTime;
    }

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
