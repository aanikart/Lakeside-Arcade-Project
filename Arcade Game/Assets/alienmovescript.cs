using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienmovescript : MonoBehaviour
{
    public GameObject alienprefab;
    public float alienspeed = 4f;
    public float alienduration = 3f;
    private static float timekeeper;

    private void Start()
    {
        
    }

    void Update()
    {
        timekeeper += Time.deltaTime;
        MoveAlien(alienprefab);

    }


    void MoveAlien(GameObject alien)
    {
        alien.transform.Translate(Vector3.down * alienspeed * Time.deltaTime);
    }

    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Hello!");
    }

}