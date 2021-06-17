using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level Config", menuName = "Demo/Level Config")]
public class LevelConfigSO : ScriptableObject
{
    public float HPScale = 1f;
    public List<SpawnerConfigSO> Spawners;

    // force the variable to not be serialized
    [System.NonSerialized] int NumActiveSpawners = 0;

    public void AttemptToChangeVariable()
    {
        Debug.Log("Old value: " + NumActiveSpawners);
        NumActiveSpawners = 50;
        Debug.Log("New value: " + NumActiveSpawners);
    }
}
