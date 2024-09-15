using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemBehavior : MonoBehaviour
{
    public Player player;



    public void PickUpItem()
    {
        Destroy(this.gameObject);
        Debug.Log("You Picked this up!");
        player.UnlockDoor();
    }
}
