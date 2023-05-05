using System.Collections;
using UnityEngine;

public class GhostHome : GhostBehavior
{
    // transform when ghost is inside home
    public Transform inside;
    // transform when ghost is outside home
    public Transform outside;

    // use a couroutine to yield/pause execution of function temporarily
    // needed for ghost home to space out ghost movement out/in of ghost home in frames

    private void OnEnable()
    {
        StopAllCoroutines();
    }

    private void OnDisable()
    {
        // prevent gameobject is not active error   
        if (gameObject.activeInHierarchy)
        {
            StartCoroutine(exitTransition());
        }
        
    }

    //
    private IEnumerator exitTransition()
    {
        ghost.Movement.SetDirection(Vector2.up, true);
        // turns off physics and movement on object during transition
        ghost.Movement.rigidbody.isKinematic = true;
        ghost.Movement.enabled = false;

        // keep track of current position
        Vector3 position = transform.position;

        float duration = 0.5f;
        float elapsed = 0.0f;

        // going from current position to inside position
        while (elapsed < duration)
        {
            // lerp interpolates between two positions  
            ghost.SetPosition(Vector3.Lerp(position, inside.position, elapsed/duration));
            // increasing time to make ghost move more and more 
            elapsed += Time.deltaTime;
            // moves once, waits a frame, then continues 
            yield return null;

        }

        // reset elapsed to restart transition
        elapsed = 0.0f;

        while (elapsed < duration)
        {
            // lerp interpolates between two positions
            ghost.SetPosition(Vector3.Lerp(inside.position, outside.position, elapsed/duration));
            // increasing time makes ghost more and more 
            elapsed += Time.deltaTime;
            // moves once, waits a frame, then continues 
            yield return null;

        }

        // after ghost is out of home, chooses random direction to move in 
        ghost.Movement.SetDirection(new Vector2(Random.value < 0.5f ? -1.0f : 1.0f, 0.0f), true);
        // turns off physics and movement on object during transition
        ghost.Movement.rigidbody.isKinematic = false;
        ghost.Movement.enabled = true;
    }

}