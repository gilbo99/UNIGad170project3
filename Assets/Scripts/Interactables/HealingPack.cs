using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPack : MonoBehaviour
{
    public float Heal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
         if(other.GetComponent<PlayerStats>().HP <= 101 && other.tag == "Player")
        {
        other.GetComponent<PlayerStats>().Healing(100);
        Destroy(gameObject);
        }
    }
}
