using UnityEngine;

public class GhostChase : GhostBehavior
{
    private void OnDisable()
    {
        ghost.scatter.enable();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Node node = other.GetComponent<Node>();

        // while ghost is frightened do nothing
        if (node != null && enabled && !ghost.frightened.enabled)
        {
            Vector2 direction = Vector2.zero;
            float minDistance = float.MaxValue;

            // find available direction that moves closest to pacman
            foreach (Vector2 availableDirection in node.availableDirections)
            {
                // if distance in this direction is less than the current distance then this direction becomes the new closest
                Vector3 newPosition = transform.position + new Vector3(availableDirection.x, availableDirection.y);
                float distance = (ghost.target.position - newPosition).sqrMagnitude;

                if (distance < minDistance)
                {
                    direction = availableDirection;
                    minDistance = distance;
                }
            }

            ghost.movement.SetDirection(direction);
        }
    }

}