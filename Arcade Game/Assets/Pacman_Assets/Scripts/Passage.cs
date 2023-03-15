using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passage : MonoBehaviour

{
    public Transform otherCollider;
    private void OnTriggerEnter2D(Collider2D firstCollider)
    {
        Vector3 pos = firstCollider.transform.position;
        pos.x = otherCollider.transform.position.x;
        pos.y = otherCollider.transform.position.y; 
        otherCollider.transform.position = pos;
        
    }
}
