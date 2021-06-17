using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spawner Config", menuName = "Demo/Spawner Config")]
public class SpawnerConfigSO : ScriptableObject
{
    public int MaxSpawnPoints = 50;
    public float SpawnInterval = 30f;
}
