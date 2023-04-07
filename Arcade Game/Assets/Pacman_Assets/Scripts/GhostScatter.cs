using UnityEngine;

public class GhostScatter : GhostBehavior
{
    private void OnDisable()
    {
        ghost.chase.enable();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Node node = other.GetComponent<Node>();

        // while ghost is frightened do nothing
        if (node != null && this.enabled && !this.ghost.frightened.enabled)
        {
            // choose random available direction
            int index = Random.Range(0, node.availableDirections.Count);

            // increment index to the next available direction
            if (node.availableDirections[index] == -this.ghost.movement.direction && node.availableDirections.Count > 1) 
            {
                index++;

                // for overflowing of indexes
                if (index >= node.availableDirections.Count)
                {
                    index = 0;
                }
            }

            this.ghost.movement.SetDirection(node.availableDirections[index]);
        }
    }

}