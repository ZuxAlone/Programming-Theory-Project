using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] List<GameObject> pickups;

    private float limit = 15;

    private void Start()
    {
        InvokeRepeating("SpawnObjects", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjects()
    {
        int randInd = Random.Range(0, pickups.Count);
        Vector3 randomPos = new Vector3(GetRandomPos(), 1, GetRandomPos());
        Instantiate(pickups[randInd], randomPos, pickups[randInd].transform.rotation);
    }

    float GetRandomPos()
    {
        return Random.Range(-limit, limit);
    }
}
