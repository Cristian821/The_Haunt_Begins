using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VaccAttacc : MonoBehaviour
{
    //general variables
    public GameObject player;
    public GameObject waypoints;
    NavMeshAgent agent;

    //State enum/variables for chase/patrol
    public enum State
    {
        Patrol,
        Chase
    }
    public State state;

    //Start
    void Start()
    {
        state = VaccAttacc.State.Patrol;
        StartCoroutine("FSM");
    }

    IEnumerator FSM()
    {
        switch (state)
        {
            case State.Patrol:
                Patrol();
                break;
            case State.Chase:
                Chase();
                break;
        }
        yield return null;
    }

    void Patrol()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(waypoints.transform.position);
    }

    void Chase()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(player.transform.position);
    } 

    //Update
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Sight"))
        {
           state = VaccAttacc.State.Chase;
           //Destroy(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        state = VaccAttacc.State.Patrol;
    }
}
