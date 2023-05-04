using UnityEngine;

public class GhostScatter : GhostBehavior
{
    private void OnDisable()
    {
        ghost.Chase.enable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();
        // if the trigger was a node, scatter behavior is enabled, and ghost is not frightened
        if (node != null && this.enabled && !ghost.Frightened.enabled)
        {
            int index = Random.Range(0, node.availableDirections.Count);
            // don't want ghost to go to node in exact opposite direction, so if it is,
            // increase index or set it equal to 0 if at the end of availableDirections list
            if (node.availableDirections[index] == -ghost.Movement.direction && node.availableDirections.Count > 1)
            {
                index++;
                // start indexes from beginning if overflowed
                if (index >= node.availableDirections.Count)
                {
                    index = 0;
                }
            }
            // have ghost move in Vector2 direction that is at index i in list 
            ghost.Movement.SetDirection(node.availableDirections[index]);


        }
    }

}