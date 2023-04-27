using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidspawner : MonoBehaviour
{
    public GameObject asteroid;
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
        transform.Rotate(Vector3.left, 1);
    }

    IEnumerator spawntimer()
    {
        float spawnY = Random.Range(min, max);

        yield return new WaitForSeconds(4);
        Instantiate(asteroid, new Vector3(11, spawnY, 0), Quaternion.identity);

        StartCoroutine(spawntimer());
    }
}
