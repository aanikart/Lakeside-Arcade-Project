using UnityEngine;

public class GhostFrightened : GhostBehavior
{

    public SpriteRenderer body;
    public SpriteRenderer eyes;
    public SpriteRenderer blue;
    public SpriteRenderer white;
    public bool isEaten { get; private set; }
    
    public override void disable()
    {
        base.disable();
        body.enabled = true;
        eyes.enabled = true;
        blue.enabled = false;
        white.enabled = false;
    }

    // call override to ensure resetting of ghost's states even if 
    // pacman eats a power pellet while ghost is already frightened
    public override void enable(float duration)
    {
        base.enable(duration);

        body.enabled = false;
        eyes.enabled = false;
        blue.enabled = true;
        white.enabled = false;

        // starts flashing halfway through ghost's frightened stage
        Invoke(nameof(Flash), duration / 2.0f);
    }

    private void eaten()
    {
        isEaten = true;
        Vector3 newPosition = ghost.Home.inside.position;
        newPosition.z = ghost.transform.position.z;
        ghost.transform.position = newPosition;

        // once ghost has reached home, enable home behavior
        ghost.Home.enable(duration);

        body.enabled = false;
        eyes.enabled = true;
        blue.enabled = false;
        white.enabled = false;
    }
    private void Flash()
    {
        // if haven't been eaten
        if (!isEaten)
        {
            blue.enabled = false;
            white.enabled = true;
            white.GetComponent<AnimatedSprite>().Restart();
        }
        
    }

    private void OnEnable()
    {
        ghost.Movement.speedMultiplier = 1f;
        // set to false so it can be eaten again
        isEaten = false;
    }

    private void OnDisable()
    {
        ghost.Movement.speedMultiplier = 1f;
        // set to false so it can be eaten again
        isEaten = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();
        // if the trigger was a node, scatter behavior is enabled, and ghost is not frightened
        if (node != null && this.enabled)
        {
            // initializing initial states of variables
            Vector2 direction = Vector2.zero;
            float maxDistance = float.MinValue;

            foreach (Vector2 availableDirection in node.availableDirections)
            {
                // calculate new direction of ghost if moving in this direction
                Vector3 newPosition = transform.position + new Vector3(availableDirection.x, availableDirection.y);
                // calculate distance between current position and new position
                float distance = (ghost.target.position - newPosition).magnitude;
                // if distance is less than minDistance, becomes new minDistance + direction is availableDirection
                if (distance > maxDistance)
                {
                    direction = availableDirection;
                    maxDistance = distance;
                }
            }
            // set movement to direction with shortest distance
            ghost.Movement.SetDirection(direction);


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            if (enabled)
            {
                eaten();
            }
        }
    }

}