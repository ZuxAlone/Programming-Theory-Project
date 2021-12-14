using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] ParticleSystem particles;

    private float rotSpeed = 1.5f;
    Vector3 rotVector; 

    // Start is called before the first frame update
    void Start()
    {
        float rotX = Random.Range(-rotSpeed, rotSpeed);
        float rotY = Random.Range(-rotSpeed, rotSpeed);
        float rotZ = Random.Range(-rotSpeed, rotSpeed);

        rotVector = new Vector3(rotX, rotY, rotZ);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotVector);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(particles, transform.position, particles.transform.rotation);
    }
}
