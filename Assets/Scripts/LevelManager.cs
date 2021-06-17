using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] LevelConfigSO Config;

    // Start is called before the first frame update
    void Start()
    {
        // if we change any serialized value in a SO at runtime the asset IS CHANGED
        // eg. a public or [SerializeField] tagged variable
        //Config.HPScale = 50f;

        Config.AttemptToChangeVariable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
