using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class enemy_final : MonoBehaviour
{

    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    public Transform player;
    private bool inRange;

    /* public enum State
    {
        Patrol,
        Chase
    } 
    public State state; */

    void Start() 
    {
        agent = GetComponent<NavMeshAgent>();
        /*agent.autoBraking = false;
        state = enemy_final.State.Patrol;
        StartCoroutine("FSM"); */
        inRange = false;

        GotoNextPoint();
    }

     /*IEnumerator FSM()
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

    }
    void Chase()
    {

    } */

    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;
        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.2f)
        {
            GotoNextPoint();
        }
        else if (inRange == true)
        {
            agent.SetDestination(player.transform.position);
        }
        else
        {
            return;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
            //state = enemy_final.State.Patrol;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            //state = enemy_final.State.Chase;
        }
    }
}