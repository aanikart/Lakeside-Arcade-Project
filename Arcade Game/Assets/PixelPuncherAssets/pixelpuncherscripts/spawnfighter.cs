using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnfighter : MonoBehaviour
{
    public GameObject mainPlayerPrefab;
    private GameObject mainPlayerInstance;

    void Start()
    {
        mainPlayerInstance = Instantiate(mainPlayerPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
