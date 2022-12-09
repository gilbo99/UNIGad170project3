using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    
    public NavMeshAgent agent;
    public Transform player;
    
    // Update is called once per frame
    void Update()
    {
       
        agent.SetDestination(player.transform.position);
    
    }
}
