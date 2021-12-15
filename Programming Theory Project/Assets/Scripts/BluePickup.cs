using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BluePickup : Pickup
{

    private int bluePoints = 5;

    // POLYMORPHISM
    public override void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(particles, transform.position, particles.transform.rotation);

        if (other.gameObject.CompareTag("Player"))
        {
            // ENCAPSULATION
            player.Points += bluePoints;
            mainUI.UpdatePoints();
        }
    }
}
