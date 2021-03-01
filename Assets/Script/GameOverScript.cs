﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "Score " + score.ToString();
    }
}
