using UnityEngine;
using UnityEngine.Rendering;

public class PlayerLook : MonoBehaviour

{
    //initialising variables 
    public Camera Camera;
    public float ySensitivity;
    public float xSensitivity;
    private float xRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //locking cursor to use the crosshair instead 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Looking(Vector2 input)
    {
        //creating variables for x and y camera movement based on mouse
        float mouseX = input.x * xSensitivity * Time.deltaTime;
        float mouseY = input.y * ySensitivity * Time.deltaTime;

        //calculate rotation
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);
        Camera.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.up * mouseX);
    }
}
