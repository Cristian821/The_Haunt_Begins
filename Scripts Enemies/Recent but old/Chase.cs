using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;
    void Start()
    {
        
    }
    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < 10)
        {
            agent.SetDestination(player.position);
        }
    }
}
