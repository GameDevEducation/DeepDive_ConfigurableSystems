using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawnable : BaseSpawnable
{
    [SerializeField] float ScaleVariation = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void PerformSpawning()
    {
        for (int numSpawned = 0; numSpawned < NumToSpawn; ++numSpawned)
        {
            // pick a random tree
            var prefab = Palette[Random.Range(0, Palette.Count)];
            
            // pick a random spwn location
            Vector3 spawnLocation = new Vector3(Random.Range(-SpawnRange, SpawnRange), 0, Random.Range(-SpawnRange, SpawnRange));

            // instantiate the tree
            GameObject newTree = GameObject.Instantiate(prefab, spawnLocation, Quaternion.identity);

            // randomise the scale
            newTree.transform.localScale = Vector3.one * (1f + Random.Range(-ScaleVariation, ScaleVariation));
        }
    }    
}
