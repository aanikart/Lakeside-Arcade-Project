using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.down * MoveSpeed) * Time.deltaTime;
    }
}
