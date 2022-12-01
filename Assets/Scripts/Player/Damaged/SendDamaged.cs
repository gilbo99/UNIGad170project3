using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendDamaged : MonoBehaviour
{
    
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
        other.GetComponent<PlayerStats>().TakeDamaged(99999);
    }
}
