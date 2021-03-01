using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SpawnerScript spawnerScript;
    ScoreScript scoreScript;
    public void StopGame()
    {
        spawnerScript = GameObject.Find("Spawner").GetComponent<SpawnerScript>();
        spawnerScript.stop = true;
    }

    public void IncreaseScore()
    {
        scoreScript = GameObject.Find("ScoreText").GetComponent<ScoreScript>();
        scoreScript.duckNum++;
    }
}
