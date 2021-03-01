using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SpawnerScript spawnerScript;
    ScoreScript scoreScript;
    GameOverScript GameOverScript;
    public GameObject gameOverScreen;

    private void Awake() {
        scoreScript = FindObjectOfType<ScoreScript>(); // to increaseScore and to get score when finish game
        gameOverScreen.SetActive(false);
    }
    
    public void StopGame()
    {
        spawnerScript = GameObject.Find("Spawner").GetComponent<SpawnerScript>();
        spawnerScript.stop = true;
        GameOver();
    }

    public void IncreaseScore()
    {
        scoreScript.duckNum++;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        GameOverScript = gameOverScreen.GetComponent<GameOverScript>();
        GameOverScript.Setup(scoreScript.duckNum);
    }
}
