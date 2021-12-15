using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    [SerializeField] protected ParticleSystem particles;
    [SerializeField] protected Player player;
    [SerializeField] protected MainUI mainUI;

    float speed = 5.0f;
    float rotSpeed = 1.5f;
    float zLimit = -22.0f;
    Vector3 rotVector;

    public abstract void OnTriggerEnter(Collider other);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        mainUI = GameObject.Find("Canvas").GetComponent<MainUI>();

        float rotX = Random.Range(-rotSpeed, rotSpeed);
        float rotY = Random.Range(-rotSpeed, rotSpeed);
        float rotZ = Random.Range(-rotSpeed, rotSpeed);

        rotVector = new Vector3(rotX, rotY, rotZ);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotVector);
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
        CheckForDestroy();
    }

    void CheckForDestroy()
    {
        if (transform.position.z < zLimit)
        {
            Destroy(gameObject);
        }
    }
}
