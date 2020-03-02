using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.AI;
public class AI_ : MonoBehaviour
{

    public NavMeshAgent agent;
    public CharacterController character;

    public enum State
    {
        Patrol,
        Chase
    }

    public State state;
    private bool alive;

    public GameObject[] waypoints;
    private int waypointInd = 0;
    public float patrolSpeed = 1f;

    //public float chaseSpeed = 0.5f;
    public GameObject target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.updatePosition = true;
        agent.updateRotation = false;

        state = AI_.State.Patrol;

        alive = true;

        StartCoroutine("FSM");
    }

    void Update()
    {
        
    }

    IEnumerator FSM()
    {
        while (alive)
        {
            switch (state)
            {
                case State.Patrol:
                    Patrol();
                    break;
                //case State.Chase:
                  //  Chase();
                  //  break;
            }
            yield return null;
        }
    }

    void Patrol()
    {
        agent.speed = patrolSpeed;
        if (Vector3.Distance(this.transform.position += transform.forward, waypoints[waypointInd].transform.position) >= 2)
        {
            agent.SetDestination(waypoints[waypointInd].transform.position);
            character.Move(transform.position * patrolSpeed * Time.deltaTime);
        }
        else if(Vector3.Distance(this.transform.position += transform.forward, waypoints[waypointInd].transform.position) <= 2)
        {
            waypointInd += 1;
            if (waypointInd >= waypoints.Length)
            {
                waypointInd = 0;
            }
        }
        else
        {
            character.Move((transform.position += transform.forward * 0 * Time.deltaTime));
        }
    }

   /* void Chase()
    {
        agent.speed = chaseSpeed;
        agent.SetDestination(target.transform.position);
        character.Move(transform.position += transform.forward * chaseSpeed * Time.deltaTime);
    } */

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            state = AI_.State.Chase;
            //Destroy(other.gameObject);
        }

        /* if (other.gameObject.CompareTag("Waypoint"))
        {
           
        } */
    } 
}
