using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    RoadSpawner roadSpawner;
    PlotSpawner plotSpawner;
    BarrierSpawner barrierSpawner;

    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        plotSpawner = GetComponent<PlotSpawner>();
        barrierSpawner = GetComponent<BarrierSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SpawnEntered()
    {
        roadSpawner.moveRoad();
        plotSpawner.spawnPlot();
        barrierSpawner.spawnBarrier();
    }
}
