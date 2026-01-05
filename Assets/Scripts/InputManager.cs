using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //initialising all movement and player actions
    private PlayerInput playerInput;
    private PlayerInput.OnGroundActions onGround;
    private PlayerMovement movement;
    private PlayerLook playerlook;
    private PlayerShooty playerShooty;
    public TextMeshProUGUI scoreText;
    void Awake()
    {

        playerInput = new PlayerInput();
        onGround = playerInput.OnGround;
        //getting the components of the input system
        movement = GetComponent<PlayerMovement>();
        playerlook = GetComponent<PlayerLook>();
        playerShooty = GetComponent<PlayerShooty>();
        onGround.Jump.performed += ctx => movement.Jump();
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        movement.Movement(onGround.movement.ReadValue<Vector2>());
        playerlook.Looking(onGround.Look.ReadValue<Vector2>());
        //shooting
        if (onGround.Shoot.IsPressed()) 
            {
            playerShooty.Shoot();
            }
        //updating score
        scoreText.text = "Your Score: " + Shooter.score.ToString();
    }
    private void OnEnable()
    {
        //enabling onground 
        onGround.Enable();
    }
    private void OnDisable()
    {
        //disabling onground
        onGround.Disable();
        
    }
}
