using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienspawnscript : MonoBehaviour
{
    public GameObject alienprefab;
    public float spawnInterval = 2f;
    private static float timeSinceLastSpawn;

    public List<float> delaytimes;
    public List<int> spawnxposition;
    private string alienname;
    GameObject alien;

    private void Start()
    {
        delaytimes = new List<float>();
        delaytimes.Add(0.5f);
        delaytimes.Add(1f);
        delaytimes.Add(2f);

        spawnxposition = new List<int>();
        spawnxposition.Add(3);
        spawnxposition.Add(-3);
        spawnxposition.Add(0);

        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            float delay = Getdelaytime();

            int randomspawnIndex = Random.Range(0, spawnxposition.Count);
            int xposition = spawnxposition[randomspawnIndex];
            
            if (xposition == -3)
            {
                alienname = "alien1";
            }
            if (xposition == 0)
            {
                alienname = "alien2";
            }
            if (xposition == 3)
            {
                alienname = "alien3";
            }

            alien = Instantiate(alienprefab, new Vector3(xposition, 6, 0), Quaternion.identity);
            alien.name = alienname;

            yield return new WaitForSeconds(delay);
        }
    }

    
    float Getdelaytime()
    {
        int randomtimeIndex = Random.Range(0, delaytimes.Count);
        float randomdelaytime = delaytimes[randomtimeIndex];
        Debug.Log("delaytime: " + randomdelaytime);
        return randomdelaytime;
    }

  




}




