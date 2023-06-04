using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passage : MonoBehaviour

{
    public Transform connection;
    private void OnTriggerEnter2D(Collider2D firstCollider)
    {
        Vector3 pos = connection.position;
        pos.z = firstCollider.transform.position.z;
        firstCollider.transform.position = pos;
    }
}
