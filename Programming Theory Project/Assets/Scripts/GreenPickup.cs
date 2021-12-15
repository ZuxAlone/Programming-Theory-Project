using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class GreenPickup : Pickup
{

    private int greenPoints = 10;

    // POLYMORPHISM
    public override void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(particles, transform.position, particles.transform.rotation);

        if (other.gameObject.CompareTag("Player"))
        {
            // ENCAPSULATION
            player.Points += greenPoints;
            mainUI.UpdatePoints();
        }
    }
}
