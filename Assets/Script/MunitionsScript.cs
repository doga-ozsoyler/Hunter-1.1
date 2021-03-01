using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MunitionsScript : MonoBehaviour
{
    GameManager gameManager;
    public Image[] bullets;

    public int munitionsNum;
    public Text munitionText;
    int bulletNum;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        bulletNum = 0;
        munitionText.text = "Munition: " + munitionsNum.ToString();
    }

    void Update()
    {
        if(bulletNum < bullets.Length)
        {
            if(Input.GetMouseButtonDown(0))
            {
                bullets[bulletNum].enabled = false;
                bulletNum++;
            }
        }
        else
        {
            if(munitionsNum != 0)
            {
                foreach (var bullet in bullets)
                {
                    bullet.enabled = true;
                }
                munitionsNum--;
                munitionText.text = "Munition: " + munitionsNum.ToString();
                bulletNum = 0;
            }
            else
            {
                gameManager.StopGame();
            }
        }
    }
}
