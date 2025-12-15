using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    //creating character controller and vector3 variables
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpPower = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //getting the componenet from the character controller
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public class to handle movement
    public void Movement(Vector2 input)
    {
        //setting the direction to 0
        Vector3 direction = Vector3.zero;
        //change direction based on inputs
        direction.x = input.x;
        direction.z = input.y;
        controller.Move(transform.TransformDirection(direction)*speed*Time.deltaTime) ;
        //checking if the player is grounded and if not applying a downward force
        if (controller.isGrounded && playerVelocity.y <0)
        {
            playerVelocity.y = -2f;
        }
        //creating gravity at the standard 9.81
        playerVelocity.y += gravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

    }
    public void Jump()
    {
        if (!controller.isGrounded) {
           return;
        }
        playerVelocity.y = jumpPower;
    }
}
