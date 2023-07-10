using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int MoveSpeed = 5;
    public Rigidbody rb;
    public Camera cam;
    Vector3 movement;
    public float turnSmoothTime = 0.5f;
    public float turnSmoothVelocity;
    public float jumpForce = 500f;
    public bool canJump = true;



    void Start()
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        


    }

    private void FixedUpdate()
    {

        Move();
        if(canJump == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(transform.up * jumpForce);
                canJump = false;

            }
        }

       


    }

    private void Move()
    {




        Vector3 direction = new Vector3(movement.x , 0f, movement.z) * Time.deltaTime;

        if (direction.magnitude >= 0.01f)
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

          

            rb.MovePosition(rb.position + moveDir.normalized * MoveSpeed * Time.fixedDeltaTime);

        }
    }

    void OnCollisionEnter(Collision collision)
    {

        canJump = true;
    }   
    




}







