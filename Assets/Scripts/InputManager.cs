using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnGroundActions onGround;
    private PlayerMovement movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerInput = new PlayerInput();
        onGround = playerInput.OnGround;
        movement = GetComponent<PlayerMovement>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement.Movement(onGround.movement.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        onGround.Enable();
    }
    private void OnDisable()
    {
        onGround.Disable();
        
    }
}
