using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 3f;
    public Transform playerBody;
    float xRotation = 0f;
    float mouseX;
    float mouseY;
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
    }

    void LateUpdate()
    {
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
