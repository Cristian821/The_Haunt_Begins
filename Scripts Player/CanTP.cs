using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanTP : MonoBehaviour
{
    public bool canTP;

    private bool ctp;

    // Start is called before the first frame update
    void Start()
    {
        canTP = true;
    }

    public void Update()
    {
        canTP = ctp;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            ctp = false;
            Debug.Log("Cant TP");
        }
        if (collision.gameObject.CompareTag("Hide Area"))
        {
            ctp = false;
            Debug.Log("Cant TP");
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ctp = false;
            Debug.Log("Cant TP");
        }
        else
        {
            ctp = true;
            Debug.Log("Can TP");
        }
    }

}
