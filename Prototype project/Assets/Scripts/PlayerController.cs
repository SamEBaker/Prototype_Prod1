using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : IPlayerState
{
    public Player player;




    public void Enter(Player player)
    {


        player.currentState = this;
    }

    public void Handle(Player player)
    {

       

        /*

        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftState leftState = new LeftState();
            leftState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            BackState backState = new BackState();
            backState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            RightState rightState = new RightState();
            rightState.Enter(player);
        }  */
    }

       
        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {

        }
    }

}
