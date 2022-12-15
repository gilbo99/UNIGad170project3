using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPack : MonoBehaviour
{
    public float heal;
    public float maxHeal;

    // when a player enters and his health is under maxHeal and gets healed the heal val 
    void OnTriggerEnter(Collider other)
    {
        
         if(other.GetComponent<PlayerStats>().HP <= maxHeal && other.tag == "Player")
        {
        other.GetComponent<PlayerStats>().Healing(heal);
        Destroy(gameObject);
        }
    }
}
