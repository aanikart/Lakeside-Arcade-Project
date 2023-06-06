using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenspawner : MonoBehaviour
{
    public GameObject green;

    public float xpos;


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
        

        yield return new WaitForSeconds(4);
        Instantiate(green, new Vector3(xpos, -1.42f, 0), Quaternion.identity);

        StartCoroutine(spawntimer());
    }
}

