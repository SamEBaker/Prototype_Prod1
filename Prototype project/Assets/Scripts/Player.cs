using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{       
    public Rigidbody rb;
    public float playerSpeed;
    public bool Key1;
    public float currSpeed;
    public float sprintSpeed;
    public Vector3 movement;
    public IPlayerState currentState;
    public StaminaController staminaController;

    void Start()
    {
        staminaController = GetComponent<StaminaController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift) && staminaController.playerStamina > 0)
        {
                staminaController.isSprinting = true;
                staminaController.Sprinting(); ;
                staminaController.UpdateStamina(1);
                currSpeed = playerSpeed + sprintSpeed;
        }
        else
        {

            staminaController.isSprinting = false;
            staminaController.UpdateStamina(0);
            currSpeed =  playerSpeed;
        }


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        currentState.Handle(this);
    }

    void FixedUpdate()
    {
        rb.velocity = (movement * currSpeed);
    }
    private void Awake()
    {
        currentState = new PlayerController();
    }

    public void UnlockDoor()
    {
        Key1 = true;
    }
}
