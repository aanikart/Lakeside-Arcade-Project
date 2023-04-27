using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Movement movement {  get; private set; }
    public GhostHome home { get; private set; }
    public GhostScatter scatter { get; private set; }
    public GhostChase chase { get; private set; }   
    public GhostFrightened frightened { get; private set; }
    // to keep track of initial behaviors of each ghost 
    public GhostBehavior initialBehavior;
    // what the ghost is chasing - in this case pacman
    public Transform target;
    public int points = 200;

    public void Start()
    {
        resetState();
    }

    // adding all scripts here so they are able to reference each other 
    private void Awake()
    {
        movement = GetComponent<Movement>();
        home = GetComponent<GhostHome>();
        scatter = GetComponent<GhostScatter>();
        chase = GetComponent<GhostChase>();
        frightened = GetComponent<GhostFrightened>();

    }

    public void resetState () 
    { 
        movement.ResetState();
        gameObject.SetActive(true);

        this.frightened.disable(); 
        this.chase.disable(); 
        this.scatter.enable(); 

        if (home != initialBehavior)
        {
            home.disable();
        }

        if (initialBehavior!= null)
        {
            initialBehavior.enable();
        }

    }

    public void SetPosition(Vector3 position)
    {
        // keep the z-position the same since it determines draw depth
        position.z = transform.position.z;
        transform.position = position;
    }

    // not colliders, but actual collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            if (frightened.enabled)
            {
                FindObjectOfType<GameManagerScript>().ghostEaten(this);
            }
            else
            {
                FindObjectOfType<GameManagerScript>().pacmanEaten();
            }
        }
    }


}
