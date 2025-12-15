using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnGroundActions onGround;
    private PlayerMovement movement;
    private PlayerLook playerlook;
    private PlayerShooty playerShooty;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerInput = new PlayerInput();
        onGround = playerInput.OnGround;
        movement = GetComponent<PlayerMovement>();
        playerlook = GetComponent<PlayerLook>();
        playerShooty = GetComponent<PlayerShooty>();
        onGround.Jump.performed += ctx => movement.Jump();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.Movement(onGround.movement.ReadValue<Vector2>());
        playerlook.Looking(onGround.Look.ReadValue<Vector2>());
        if (onGround.Shoot.IsPressed()) 
            {
            playerShooty.Shoot();
            }
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
