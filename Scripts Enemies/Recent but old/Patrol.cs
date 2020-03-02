using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform[] waypoints;
    private int destination;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        NextPoint();
    }

    void NextPoint()
    {
        if (waypoints.Length == 0)
        {
            return;
        }
        agent.destination = waypoints[destination].position;

        destination = destination++ % waypoints.Length;
    }

    private void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
            NextPoint();
        }
    }
}
