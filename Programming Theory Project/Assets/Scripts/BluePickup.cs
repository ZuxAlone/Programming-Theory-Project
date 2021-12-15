using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePickup : Pickup
{

    private int bluePoints = 5;

    public override void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(particles, transform.position, particles.transform.rotation);

        if (other.gameObject.CompareTag("Player"))
        {
            player.Points += bluePoints;
            mainUI.UpdatePoints();
        }
    }
}
