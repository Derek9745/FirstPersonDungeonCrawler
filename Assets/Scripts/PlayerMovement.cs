using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int MoveSpeed = 5;
    public Rigidbody rb;
    Vector3 move;
    public float turnSmoothTime = 0.5f;
    public float turnSmoothVelocity;
    public float jumpForce = 300f;
   public bool grounded;
    public float distToGround = .1f;
    public LayerMask layermask;
    public Transform player;


    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        move = transform.right * x + transform.forward * z;
        isGrounded();

    }

    private void FixedUpdate()
    {
  
         if(isGrounded() == true){
            grounded = true;
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(transform.up * jumpForce);
            }  
        }
        else
            grounded = false;
        Move();
    }

    private void Move()
    {
        

        rb.MovePosition(rb.position + move.normalized * MoveSpeed * Time.fixedDeltaTime);

        // Vector3 direction = new Vector3(movement.x , 0f, movement.z) * Time.deltaTime;

        //if (direction.magnitude >= 0.01f)
        //{

        //float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
        //float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        // transform.rotation = Quaternion.Euler(0f, angle, 0f);

        // Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;



        //rb.MovePosition(rb.position + moveDir.normalized * MoveSpeed * Time.fixedDeltaTime);

        // }
    }

    //void OnCollisionEnter(Collision collision)
   // {

       // grounded = true;
    //}  
    bool isGrounded()
    {
        return Physics.Raycast(player.transform.position, Vector3.down,distToGround, layermask);
    }




}







