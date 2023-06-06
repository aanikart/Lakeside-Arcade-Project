using System.Collections.Generic;
using UnityEngine;

// tile and node sprites from https://github.com/zigurous/unity-pacman-tutorial/tree/main/Assets/Tiles

public class Node : MonoBehaviour
{
    public LayerMask obstacleLayer;
    public List<Vector2> availableDirections { get; private set; }

    private void Start()
    {
        availableDirections = new List<Vector2>();

        // check available direction on all directions
        checkAvailableDirection(Vector2.up);
        checkAvailableDirection(Vector2.down);
        checkAvailableDirection(Vector2.left);
        checkAvailableDirection(Vector2.right);
    }

    private void checkAvailableDirection(Vector2 direction)
    {
        // detect hit with tiles and obstacles
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0f, direction, 1f, obstacleLayer);

        // if no hit, then there is no obstacle in that direction, so and direction is available
        if (hit.collider == null)
        {
            availableDirections.Add(direction);
        }
    }

}