using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    ParticleSystem particles;

    // Start is called before the first frame update
    void Start()
    {
        particles = GetComponent<ParticleSystem>();
        StartCoroutine(PlaySystem());
    }

    IEnumerator PlaySystem()
    {
        particles.Play();
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
