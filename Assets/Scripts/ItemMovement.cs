using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{

    public float amplitude = .2f;
    public float frequency = 1f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    void Start()
    {
        posOffset = transform.position;
    }


    void FixedUpdate()
    {

        tempPos = posOffset;
        tempPos.y += Mathf.Cos(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
        transform.Rotate(1f, 5 * Time.deltaTime, 1f, Space.Self);
    }
}