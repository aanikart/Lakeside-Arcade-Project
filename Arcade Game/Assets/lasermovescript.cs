using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class lasermovescript : MonoBehaviour
{
    public GameObject laserPrefab;
    public float laserSpeed = 5f;
    public float laserDuration = 5f;
    private bool laserActive = false; 

    void Update()
    {
        if (!laserActive) 
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SpawnLaser("Laser1", -3, -5);
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
    }

    void SpawnLaser(string laserType, int xc, int yc)
    {
        laserActive = true; 
        GameObject laser = Instantiate(laserPrefab, new Vector3(xc, yc, 0), Quaternion.identity);
        laser.name = laserType;

        StartCoroutine(MoveLaser(laser));
        Destroy(laser, laserDuration);
    }

    IEnumerator MoveLaser(GameObject laser)
    {
        while (laser != null)
        {
            laser.transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
            yield return null;
        }
        
        Destroy(laser);
        laserActive = false; 
    }

}
