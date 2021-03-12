using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSpeed = 300f;


    public Transform playerBody; //This is so we know and can rotate the player when we move left and right

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //--------Start Mouse Movment-------
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        xRotation -= mouseY; // Tutorial said that it was flipped, so negative it is
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //So you cant look too far up or down
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //This is to move left and right, Quaternion is your rotation
        playerBody.Rotate(Vector3.up * mouseX); 
        //-------End Mouse Movment----------


    }
}
