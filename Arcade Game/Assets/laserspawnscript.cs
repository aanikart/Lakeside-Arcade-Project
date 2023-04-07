using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class laserspawnscript : MonoBehaviour
{
    public GameObject laserPrefab;

    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpawnLaser("Laser1", -3, -5);
            Debug.Log("alpha 1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpawnLaser("Laser2", 0, -5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SpawnLaser("Laser3", 3, -5);
        }
        
    }

    void SpawnLaser(string laserType, int xc, int yc)
    {
        
        GameObject laser = Instantiate(laserPrefab, new Vector3(xc, yc, 0), Quaternion.identity);
        laser.name = laserType;

    }

   

}
