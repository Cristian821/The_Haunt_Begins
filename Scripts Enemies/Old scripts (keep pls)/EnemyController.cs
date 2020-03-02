using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                    //Face the target
                FaceTarget();
            }
        }
        else
        {
                //enemy pathing
            Pathing();
        }
    }
    void FaceTarget()
    {
            //direction to target
        Vector3 direction = (target.position - transform.position).normalized;
            //rotation point to target
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            //update rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void Pathing()
    {
        //enemy pathing
    }
}

