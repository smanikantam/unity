using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyplayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        // if(col.gameObject.tag == "ground")
        //     grounded=true;

        if (col.gameObject.tag.Equals("killer"))
        {
            // Destroy(col.gameObject); it will destroy the both player and collider
            Destroy(gameObject); //it will destroy only player
        }
    }
}