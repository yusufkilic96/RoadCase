using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : MonoBehaviour
{
    private int initAmount = 4;
    private float plotSize = 30f;
    private float lastZPos = -10.12f;

    public List<GameObject> barriers;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            spawnBarrier();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBarrier()
    {
        GameObject barrier = barriers[Random.Range(0, barriers.Count)];
        float zPos = lastZPos + plotSize;

        Instantiate(barrier, new Vector3(Random.Range(-5.3f, 1.1f), 0.025f, zPos), barrier.transform.rotation);

        lastZPos += plotSize;
    }

    
}
