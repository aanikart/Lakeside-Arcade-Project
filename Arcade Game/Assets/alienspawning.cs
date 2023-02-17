using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienspawning : MonoBehaviour
{
    public GameObject Alien;
    public float spawnrate = 5;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnAlien();
            timer = 0;
        }
    }

    void spawnAlien()
    {
        Instantiate(Alien, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
