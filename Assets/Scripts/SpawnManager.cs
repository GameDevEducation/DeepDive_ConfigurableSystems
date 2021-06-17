using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<BaseSpawnable> Spawnables;

    // Start is called before the first frame update
    void Start()
    {
        // perform the spawning
        foreach(var spawnable in Spawnables)
        {
            spawnable.PerformSpawning();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
