using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public Ghost[] ghosts;
    public Pacman pacman;
    public Transform pellets;
    public int ghostMultiplier { get; private set; } = 1;
    public int score { get; private set; }
    public int lives { get; private set; }

    private void Start()
    {
        newGame();
    }

    private void Update()
    {
        if (lives <= 0 &&  Input.anyKeyDown)
        {
            newGame();
        }
    }

    private void newGame()
    {
        setScore(0);
        setLives(3);
        newRound();
    }

    private void newRound()
    {
        foreach (Transform pellet in pellets)
        {
            pellet.gameObject.SetActive(true);
        }

        resetState();
    }

    // resetting state of ghosts by looping and pacman 
    private void resetState()
    {
        for (int i = 0; i < ghosts.Length; i++)
        {
            ghosts[i].resetState();
        }

        pacman.resetState();
    }

    private void gameOver()
    {
        for (int i = 0; i < ghosts.Length; i++)
        {
            ghosts[i].gameObject.SetActive(false);
        }

        pacman.gameObject.SetActive(false);
    }

    private void setScore(int score)
    {
        this.score = score;
    }

    private void setLives(int lives)
    {
        this.lives = lives;
    }

    public void ghostEaten(Ghost ghost)
    {
        int points = ghost.points * ghostMultiplier;
        setScore(score + ghost.points);

        ghostMultiplier++;
    }

    public void pacmanEaten()
    {
        pacman.gameObject.SetActive(false);

        setLives(lives - 1);

        if (lives > 0)
        {
            Invoke(nameof(resetState), 3.0f);
        }
        else
        {
            gameOver();
        }

    }

    public void pelletEaten(PelletEaten pellet)
    {
        pellet.gameObject.SetActive(false);
        setScore(score + pellet.points);

        if (!hasRemainingPellets())
        {
            pacman.gameObject.SetActive(false);
            Invoke(nameof(newRound), 3.0f);
        }
    }

    public void powerPelletEaten(PowerPelletEaten pellet)
    {
        pelletEaten(pellet);
        CancelInvoke(nameof(resetGhostMultipler));
        Invoke(nameof(resetGhostMultipler), pellet.duration);
    }

    private bool hasRemainingPellets()

    {
        foreach (Transform pellet in this.pellets)
        {
            if (pellet.gameObject.activeSelf)
            {
                return true;
            }
        }

        return false;
    }

    private void resetGhostMultipler()
    {
        ghostMultiplier = 1;
    }

}
