using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{

    private int initAmount = 5;
    private float plotSize = 30f;
    private float xPosLeft = -31;
    private float xPosRight = 31;
    private float lastZPos = -15f;

    public List<GameObject> plots;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < initAmount; i++)
        {
            spawnPlot();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnPlot()
    {
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        Instantiate(plotLeft, new Vector3(xPosLeft, 0.025f, zPos), plotLeft.transform.rotation);
        Instantiate(plotLeft, new Vector3(xPosRight, 0.025f, zPos), new Quaternion(0, 180, 0, 0));

        lastZPos += plotSize;
    }
}
