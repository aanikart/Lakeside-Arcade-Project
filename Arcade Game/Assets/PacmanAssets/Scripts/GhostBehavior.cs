using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract makes it so that you can never have a ghost behavior by itself on a game object,
// it needs to have something that inherits it 
public abstract class GhostBehavior : MonoBehaviour
{
    public Ghost ghost { get; private set; }
    public float duration;

    private void Awake()
    {
        
        ghost = GetComponent<Ghost>();
        // initially start out as false 
        this.enabled = false;
    }

    // enable ghost behavior with default duration
    public void enable()
    {
        enable(duration);
    }

    // for when there is a dependence on other durations, e.g. power pellet duration
    // virtual so they can be overriden in individual behavior classes
    public virtual void enable (float duration)
    {
        enabled = true;

        // set a timer that will disable behavior after duration 
        Invoke(nameof(disable), duration);
    }

    public virtual void disable ()
    {
        // disable behavior
        enabled = false;

        CancelInvoke();
    }

}
