using UnityEngine;

public class Pacman : MonoBehaviour
{
    public AnimatedSprite deathSequence;
    public SpriteRenderer spriteRenderer;
    public new Collider2D collider { get; private set; }
    public Movement movement { get; private set; }

    public float rotationSpeed {  get; private set; }

    private void Awake()
    {
        collider = GetComponent<Collider2D>();
        movement = GetComponent<Movement>();
        spriteRenderer= GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        rotationSpeed = 4f;
        // use arrow keys to move pacman
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movement.SetDirection(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movement.SetDirection(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movement.SetDirection(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movement.SetDirection(Vector2.right);
        }

        // rotate pacman object depending on its direction
        // from https://stackoverflow.com/questions/71606348/how-to-rotate-a-2d-object-by-90-degrees-in-unity and https://docs.unity3d.com/ScriptReference/Quaternion.html
        float angle = Mathf.Atan2(movement.direction.y, movement.direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);

        Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movement.direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

    }
 
    // reset movement state and turn object back on 
    // disable/enable certain behaviors depending on initial behavior
    public void resetState()
    {
        this.enabled = true;
        spriteRenderer.enabled = true;
        collider.enabled = true;
        movement.resetState();
        gameObject.SetActive(true);
    }
}