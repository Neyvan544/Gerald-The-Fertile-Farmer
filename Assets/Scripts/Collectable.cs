using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public CollectableType type;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerScript player = collision.GetComponent<PlayerScript>();

        if(player)
        {
            player.inventory.Add(type);
            Destroy(this.gameObject);
        }
    }
}

public enum CollectableType
{
    None, Carrot_seed
}
