using UnityEngine;

public class GhostChase : GhostBehavior
{
    // when chase is disabled, enable trigger behavior
    private void OnDisable()
    {
        ghost.Scatter.enable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();
        // if the trigger was a node, scatter behavior is enabled, and ghost is not frightened
        if (node != null && this.enabled && !ghost.Frightened.enabled)
        {
            // initializing initial states of variables
            Vector2 direction = Vector2.zero;
            float minDistance = float.MaxValue;

            foreach (Vector2 availableDirection in node.availableDirections)
            {
                // calculate new direction of ghost if moving in this direction
                Vector3 newPosition = transform.position + new Vector3(availableDirection.x, availableDirection.y);
                // calculate distance between current position and new position
                float distance = (ghost.target.position - newPosition).magnitude;
                // if distance is less than minDistance, becomes new minDistance + direction is availableDirection
                if (distance < minDistance)
                {
                    direction = availableDirection;
                    minDistance = distance;
                }
            }
            // set movement to direction with shortest distance
            ghost.Movement.SetDirection(direction);


        }
    }

}

