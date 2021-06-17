using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpawnable : MonoBehaviour
{
    [SerializeField] protected List<GameObject> Palette;
    [SerializeField] protected int NumToSpawn = 5;
    [SerializeField] protected float SpawnRange = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void PerformSpawning()
    {

    }
}
