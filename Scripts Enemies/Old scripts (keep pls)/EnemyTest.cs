using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyTest : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 1;
    int MinDist = 1;
    public bool canSee;

    public float FOVAngle = 110f;
    public bool playerThere;
    public Vector3 lastLocation;

    private SphereCollider col;

    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //
            }

        } 
    }
}