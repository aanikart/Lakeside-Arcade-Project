using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienmovescript : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float deadZone = -7;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.down * MoveSpeed) * Time.deltaTime;
    }
}
