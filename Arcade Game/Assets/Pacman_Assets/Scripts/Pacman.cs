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
        //deathSequence.enabled = false;
        //deathSequence.spriteRenderer.enabled = false;
        movement.ResetState();
        gameObject.SetActive(true);
    }
}