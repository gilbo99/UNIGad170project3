using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendDamaged : MonoBehaviour
{
    
   // so i could test the PlayerStats TakeDamaged function

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "player")
        {
        other.GetComponent<PlayerStats>().TakeDamaged(99999);
        }
    }
}
