using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserspawnleft : MonoBehaviour
{
    public GameObject laserbeam;
    public float lspawnrate = 1;
    private float ltimer = 0;
    //public bool firelaser;


    // Start is called before the first frame update
    void Start()
    {
        spawnlaser();
    }

    // Update is called once per frame
    
    void Update()
    {
        if (ltimer < lspawnrate)
        {
            ltimer = ltimer + Time.deltaTime;
        }
        else
        {
            if (GameObject.Find("laserbeam").transform.position.y > -2.5)
            {
                spawnlaser();
            }
            ltimer = 0;
        }
        

    }
    
    void spawnlaser()
    {
        Instantiate(laserbeam, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
