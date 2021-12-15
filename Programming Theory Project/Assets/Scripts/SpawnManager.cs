using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] List<GameObject> pickups;

    private float limit = 9;

    private void Start()
    {
        InvokeRepeating("SpawnObjects", 1.0f, 1.5f);
    }

    void SpawnObjects()
    {
        int randInd = Random.Range(0, pickups.Count);
        Vector3 randomPos = new Vector3(GetRandomPos(), 1, 19);
        Instantiate(pickups[randInd], randomPos, pickups[randInd].transform.rotation);
    }

    float GetRandomPos()
    {
        return Random.Range(-limit, limit);
    }
}
