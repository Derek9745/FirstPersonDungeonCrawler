using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBobController : MonoBehaviour
{
    public bool isMoving = true;
    [SerializeField, Range(0, 10f)] private float amplitude = .45f;
    [SerializeField, Range(0, 30)] private float frequency = 10.0f;

    private float toggleSpeed = 3.0f;
    [SerializeField] private Transform cam = null;
    [SerializeField] private Transform cameraHolder = null;
    Vector3 startPos;
    public  Rigidbody controller;
    PlayerMovement movement;

    void Awake()
    {
        controller = GetComponent<Rigidbody>();
        startPos = cam.localPosition;
        
    }
    private void Update()
    {
        if (!isMoving) return;

        CheckMotion();
        ResetPosition();
        cam.LookAt(FocusTarget());
    }

    private Vector3 HeadBob()
    {
        Vector3 pos = Vector3.zero;
        pos.y += Mathf.Sin(Time.time * frequency) * amplitude;
        pos.x += Mathf.Cos(Time.time * frequency) * amplitude;
        return pos;

    }
     private void ResetPosition()
    {
        if (cam.localPosition == startPos) 
        return;
        cam.localPosition = Vector3.Lerp(cam.localPosition, startPos, 1 * Time.deltaTime);
    }

    private Vector3 FocusTarget()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y + cameraHolder.localPosition.y, transform.position.z);
        pos += cameraHolder.forward * 15.0f;
        return pos;
    }

    private void CheckMotion()
    {
        float speed = new Vector3(controller.velocity.x, 0, controller.velocity.z).magnitude;
        ResetPosition();
        if (speed < toggleSpeed) return;
        if (!movement.grounded == true) return;

        PlayMotion(HeadBob());
    }

    private void PlayMotion(Vector3 motion)
    {
        cam.localPosition += motion;
    }
}