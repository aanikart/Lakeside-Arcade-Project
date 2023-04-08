using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract makes it so that you can never have a ghost behavior by itself; it needs to have something that inherits it 
public abstract class GhostBehavior : MonoBehaviour
{
    public Ghost ghost { get; private set; }
    public float duration;

    private void Awake()
    {
        
        this.ghost = GetComponent<Ghost>();
        this.enabled = false;
    }

    // enable ghost without specifying duration with default duration
    public void enable()
    {
        enable(this.duration);
    }

    // when there is a dependence on other durations, e.g. power pellet duration
    public virtual void enable (float duration)
    {
        this.enabled = true;

        Invoke(nameof(disable), duration);
    }

    public virtual void disable ()
    {
        this.enabled = false;

        CancelInvoke();
    }

}
