using System.ComponentModel.Design;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //creating character controller and vector3 variables
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;
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
    }
}
