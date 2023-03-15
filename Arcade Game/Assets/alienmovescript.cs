using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienmovescript : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource musicSource;

    public GameObject alienprefab;
    public float alienduration = 5f;
    public float alienspeed = 5f;

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        musicSource.clip = musicClip;
        musicSource.Play();
    }

    void Update()
    {
        InvokeRepeating("spawnalien", 0f, 2f);

    }

    void spawnalien()
    {
        GameObject alien = Instantiate(alienprefab, new Vector3(0, 5, 0), alienprefab.transform.rotation);

        StartCoroutine(MoveLaser(alien));
        Destroy(alien, alienduration);
    }

    IEnumerator MoveLaser(GameObject alien)
    {
        while (alien != null)
        {
            alien.transform.Translate(Vector3.down * alienspeed * Time.deltaTime);
            yield return null;
        }
    }
}



/*
using UnityEngine;
using System.Collections;

public class AlienSpawner : MonoBehaviour
{

    public GameObject alienPrefab;
    public float spawnInterval = 2f;
    public float alienSpeed = 5f;
    public float alienduration = 5f;

    private bool alienactive = false;

    private float lastSpawnTime;

    void Start()
    {
        lastSpawnTime = Time.time;
    }

    void Update()
    {
       
        if (!alienactive)
        {
            if (Time.time - lastSpawnTime > spawnInterval)
            {
                SpawnAlien(0,6);
                lastSpawnTime = Time.time;
            }
        }
    }

    void SpawnAlien(int xc, int yc)
    {
        alienactive = true;
        GameObject alien = Instantiate(alienPrefab, new Vector3(xc, yc, 0), Quaternion.identity);
 
        
        StartCoroutine(movealien(alienPrefab));
        Destroy(alien, alienduration);
    }

    IEnumerator movealien(GameObject alien)
    {
        while (alien != null)
        {
            alien.transform.Translate(Vector3.down * alienSpeed * Time.deltaTime);
            yield return null;
        }

        Destroy(alien);
        alienactive = false;
    }
}
*/