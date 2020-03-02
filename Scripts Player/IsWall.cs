using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsWall : MonoBehaviour
{
    public bool isWall;

    private bool iw;

    // Start is called before the first frame update
    void Start()
    {
        isWall = false;
    }
    public void Update()
    {
        isWall = iw;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Wall")
        {
            iw = true;
            Debug.Log("Cant Pass Wall");
        }
        else
        {
            iw = false;
            Debug.Log("Can Pass Wall");
        }
    }


}
