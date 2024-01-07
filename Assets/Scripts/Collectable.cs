using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerScript player = collision.GetComponent<PlayerScript>();

        if(player)
        {
            player.carrotSeedsCount++;
            Destroy(this.gameObject);
        }
    }
}
