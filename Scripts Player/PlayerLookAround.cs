using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAround : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float stickSensitivity = 100f;
    public Transform playerBody;
    float xRotate = 0f;

    void Start()
    {
        //Hides mouse during gameplay
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        //Grab mouse inputs
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Grab stick inputs
        float stickX = Input.GetAxis("StickHoz") * stickSensitivity * Time.deltaTime;
        float stickY = Input.GetAxis("StickVer") * stickSensitivity * Time.deltaTime;

        //Rotate player
        xRotate -= mouseY;
        xRotate -= stickY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        playerBody.Rotate(Vector3.up * stickX);
    }
}
