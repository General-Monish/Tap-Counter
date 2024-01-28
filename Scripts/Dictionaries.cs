using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    public Dictionary<string, int>LevelScore = new Dictionary<string, int>();

   
    // Start is called before the first frame update
    void Start()
    {
        LevelScore["Level 1"] = 10;
        LevelScore["Level 2"] = 20;
        LevelScore["Level 3"] = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
