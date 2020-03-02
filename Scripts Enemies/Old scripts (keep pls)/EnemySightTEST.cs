using System.Collections;

using UnityEngine;
using UnityEngine.AI;

public class EnemySightTEST : MonoBehaviour
{
    public float FOVAngle = 110f;
    public bool playerThere;
    public Vector3 lastLocation;

    private NavMeshAgent nav;
    private SphereCollider col;

}