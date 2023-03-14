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
