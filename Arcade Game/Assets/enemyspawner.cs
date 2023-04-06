using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject enemy;
    public float min = -3.8f; 
    public float max = 3.8f;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawntimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawntimer()
    {
        float spawnY = Random.Range(min, max);

        yield return new WaitForSeconds(3);
        Instantiate(enemy, new Vector3(11, spawnY, 0), Quaternion.identity);
        
        StartCoroutine(spawntimer());
    }
}
