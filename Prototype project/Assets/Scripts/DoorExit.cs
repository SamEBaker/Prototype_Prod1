using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExit : MonoBehaviour
{
    public Player player;
    public bool Locked;
    public GameObject Door;

    public void OpenDoor()
    {
        if(Locked == true)
        {
            if(player.Key1 == true)
            {
                Locked = false;
                Debug.Log("Entering next area");
                //HUD fade to black 
                player.transform.position = Door.transform.position;


            }
            else
            {
                Debug.Log("Door is locked!");
            }
        }
        else
        {
            Debug.Log("Entering next area");
            player.transform.position = Door.transform.position;
        }
        

    }

    /*

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" && player.hasItem == true)
        {
            Locked = false;
            Debug.Log("Entering next area");
            player.transform.position = Door.transform.position;
        }
        else
        {
            Debug.Log("Door is locked!");
        }

    }
    */
}
