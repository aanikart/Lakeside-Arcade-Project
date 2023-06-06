using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidspawner : MonoBehaviour
{
    public GameObject asteroid;
    public float min = -3.8f;
    public float max = 3f;



    
    void Start()
    {
        // spawns after certain period of time
        StartCoroutine(spawntimer());
    }

  
    void Update()
    {
        transform.Rotate(Vector3.left, 1);
    }

    IEnumerator spawntimer()
    {
        // finds random y position to spawn asteroid
        float spawnY = Random.Range(min, max);

        //spawns every 4 seconds
        yield return new WaitForSeconds(4);
        Instantiate(asteroid, new Vector3(11, spawnY, 0), Quaternion.identity);

        StartCoroutine(spawntimer());
    }
}
