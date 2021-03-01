using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleScoreScript : MonoBehaviour
{
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.IncreaseScore();
    }
}
