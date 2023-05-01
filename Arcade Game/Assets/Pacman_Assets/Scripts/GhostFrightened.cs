using UnityEngine;

public class GhostFrightened : GhostBehavior
{
    private void OnDisable()
    {
        ghost.Scatter.enable();
    }


}