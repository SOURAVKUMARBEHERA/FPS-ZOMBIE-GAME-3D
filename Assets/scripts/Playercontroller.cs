using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed = 10f;
    public float sensitivity = 5f;
    public float jumpForce = 10f;
    
    // public bool isJumping = false;
    public Camera cam;
    


    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        

    PlayerMovement() ;
    PlayerRotation();


    }

    void PlayerMovement()
    {
        float movX = Input.GetAxisRaw("Horizontal") ;
        float movZ = Input .GetAxisRaw("Vertical") ;

        Vector3 movePlayer = new Vector3(movX, 0, movZ);
        transform. Translate(movePlayer * Time.fixedDeltaTime * speed, Space.Self);

        if (Input.GetKeyDown(KeyCode.Space))
            
        {
            rb.AddForce(Vector3.up * jumpForce);
        //     if (isJumping == false)
        //     {
               
        //         isJumping = true;
        //     }
            
        // }

    // }
    //     private void OnCollisionEnter(Collision collision)
    //     {
    //     if (collision.gameObject.tag == "Grounds")
    //     {
    //             isJumping = false;
        }
        }
    void  PlayerRotation()
    {
        float rotateY = Input .GetAxisRaw("Mouse X");

        Vector3 rotation = new Vector3(0,rotateY, 0) * sensitivity;
        transform. Rotate(rotation) ;


       float rotateX = Input.GetAxisRaw("Mouse Y");
       Vector3 camRotation = new Vector3(rotateX, 0, 0) * sensitivity;
       cam.transform.Rotate(-camRotation);
    


    }
    

}
