using UnityEngine;
using UnityEngine.AI;

public class PlayerCpntroler : MonoBehaviour
{

    
    public NavMeshAgent agent;
    public Transform player;
    
    // Update is called once per frame
    void Update()
    {
       
        agent.SetDestination(player.transform.position);
    
    }
}
