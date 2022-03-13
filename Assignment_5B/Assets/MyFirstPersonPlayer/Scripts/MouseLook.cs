using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //Get mouse input & assign it to two floats
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotate player game object with hori mouse input
        player.transform.Rotate(Vector3.up * mouseX);


        //rotate the camera around the x axis with vertical mouse input
        verticalLookRotation -= mouseY;


        //Limit vertical rotation with clamp
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        //apply rotation to camera
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);


    }
}
