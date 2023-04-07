using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class lasermovescript : MonoBehaviour
{
    public GameObject laserPrefab;
    public float laserSpeed = 5f;
    public float laserDuration = 5f;

    private void Start()
    {

    }

    void Update()
    {
        MoveLaser(laserPrefab);
        /*while (laserPrefab.transform.position.y < 6)
        {
            MoveLaser(laserPrefab);
        }
        Destroy(laserPrefab);*/
    }
      
    void MoveLaser(GameObject laser)
    {
        laser.transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

    }

}
