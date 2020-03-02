using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class VaccMesh : MonoBehaviour
{
    public GameObject destination;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(destination.transform.position);
    }
}
