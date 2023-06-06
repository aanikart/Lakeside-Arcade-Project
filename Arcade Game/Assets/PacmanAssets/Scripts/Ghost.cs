using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Movement Movement { get; private set; }
    public GhostHome Home { get; private set; }
    public GhostScatter Scatter { get; private set; }
    public GhostChase Chase { get; private set; }
    public GhostFrightened Frightened { get; private set; }
    // to keep track of initial behaviors of each ghost 
    public GhostBehavior initialBehavior;
    // what the ghost is chasing - in this case pacman
    public Transform target;
    public int points = 0;

    public void Start()
    {
        resetState();
    }

    // add all scripts so they can reference each other 
    private void Awake()
    {
        Movement = GetComponent<Movement>();
        Home = GetComponent<GhostHome>();
        Scatter = GetComponent<GhostScatter>();
        Chase = GetComponent<GhostChase>();
        Frightened = GetComponent<GhostFrightened>();

    }
    // reset movement state and turn object back on 
    // disable/enable certain behaviors depending on initial behavior
    public void resetState()
    {
        Movement.resetState();
        gameObject.SetActive(true);

        Frightened.disable();
        Chase.disable();
        Scatter.enable();

        if (Home != initialBehavior)
        {
            Home.disable();
        }


        if (initialBehavior != Scatter)
        {
            Scatter.disable();
            initialBehavior.enable();
        }

    }

    public void SetPosition(Vector3 position)
    {
        // keep the z-position the same since it determines draw depth
        position.z = transform.position.z;
        transform.position = position;
    }

    // detects collisions and categorizes them based on type
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            if (Frightened.enabled)
            {
                // if ghost is in frightened mode, collision means ghost is eaten 
                FindObjectOfType<GameManagerScript>().ghostEaten(this);
            }
            else
            {
                // if not, collision means pacman is eaten
                FindObjectOfType<GameManagerScript>().pacmanEaten();
            }
        }
    }


}
