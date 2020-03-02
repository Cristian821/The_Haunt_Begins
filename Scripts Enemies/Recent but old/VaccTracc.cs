using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VaccTracc : MonoBehaviour
{
    public int x;
    public int z;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            x = Random.Range(-75, 5);
            z = Random.Range(70, 10);
            gameObject.transform.position = new Vector3(x, 7, z);
        }
        /*
         if (other.gameObject.CompareTag("Waypoint"))
         {
             x = Random.Range(-75, 5);
             z = Random.Range(70, 10);
             gameObject.transform.position = new Vector3(x, 7, z);
         }
         if (other.gameObject.CompareTag("Waypointt"))
         {
             x = Random.Range(-75, 5);
             z = Random.Range(70, 10);
             gameObject.transform.position = new Vector3(x, 7, z);
         }
         if (other.gameObject.CompareTag("Waypoint"))
         {
             x = Random.Range(-75, 5);
             z = Random.Range(70, 10);
             gameObject.transform.position = new Vector3(x, 7, z);
         }
         */
    }
}
