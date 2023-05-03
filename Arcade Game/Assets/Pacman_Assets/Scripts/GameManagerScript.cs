using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public Ghost[] ghosts;
    public Pacman pacman;
    // array of Transform pellets
    public Transform pellets;
    public int pointMultiplier { get; private set; } = 1;
    public static int score { get; private set; }
    public int lives { get; private set; }
    public Text scoreText;
    public Text livesText;

    private void Start()
    {
        newGame();
    }

    private void Update()
    {
        if (lives <= 0 && Input.anyKeyDown)
        {
            newGame();
        }
    }

    // initialize variables once game is started
    private void newGame()
    {
        setScore(0);
        setLives(3);
        newRound();
    }

    // each new round, reactivate the pellets
    private void newRound()
    {
        foreach (Transform pellet in pellets)
        {
            pellet.gameObject.SetActive(true);
        }

        // each new round, reset states of game objects
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

    // if game is over, set states of game objects to inactive
    private void gameOver()
    {
        for (int i = 0; i < ghosts.Length; i++)
        {
            ghosts[i].gameObject.SetActive(false);
        }

        pacman.gameObject.SetActive(false);

    }

    private void setScore(int newScore)
    {
        score += newScore;
        scoreText.text = score.ToString();
    }

    private void setLives(int lives)
    {
        this.lives = lives;
        livesText.text = lives.ToString();
    }

    // adds points to pacman score if ghost is eaten
    // each time a ghost in frightened mode is eaten, pointMultiplier increases 
    public void ghostEaten(Ghost ghost)
    {
        int points = ghost.points * pointMultiplier;
        setScore(score + ghost.points);

        pointMultiplier++;
    }

    // pacman behavior if eaten - depending on 
    public void pacmanEaten()
    {
        pacman.gameObject.SetActive(false);
        

        setLives(lives - 1);

        if (lives > 0)
        {
            Invoke(nameof(resetState), 2.0f);
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
        CancelInvoke(nameof(resetPointMultipler));
        Invoke(nameof(resetPointMultipler), pellet.duration);
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

    private void resetPointMultipler()
    {
        pointMultiplier = 1;
    }

}
