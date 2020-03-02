using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPoints : MonoBehaviour
{

    // put the points from unity interface
    public Transform[] wayPointList;

    public int currentWayPoint = 0;
    Transform targetWayPoint;
    public NavMeshAgent agent;

    public float speed = 10f;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(targetWayPoint.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        // check if we have somewere to walk
        if (currentWayPoint < this.wayPointList.Length)
        {
            if (currentWayPoint >= wayPointList.Length)
                currentWayPoint = 0;
        }
    }

    void walk()
    {
        agent = GetComponent<NavMeshAgent>();
        //rotate towards the target
        //agent.transform.forward = Vector3.RotateTowards(agent.transform.forward, targetWayPoint.position - transform.position, speed * Time.deltaTime, 0.0f);

        // move towards the target
        agent.SetDestination(targetWayPoint.transform.position);

        if (agent.transform.position == targetWayPoint.position)
        {
            currentWayPoint++;
            targetWayPoint = wayPointList[currentWayPoint];
        }
    }
}
