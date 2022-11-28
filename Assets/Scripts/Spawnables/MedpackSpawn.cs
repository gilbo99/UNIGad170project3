using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedpackSpawn : MonoBehaviour
{
    public GameObject myPrefab;  
    public Transform  Spawn;  
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(Spawn.transform.position.x, Spawn.transform.position.y, Spawn.transform.position.z), Quaternion.identity);       
    }

    // Update is called once per frame
    void Update()
    {
       
        
           
        
    }
}
