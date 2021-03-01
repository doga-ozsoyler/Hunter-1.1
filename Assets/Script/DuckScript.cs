using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckScript : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, -1) * Time.deltaTime * 10f;
        DestroyDuck();
    }

    public void DestroyDuck()
    {
        Destroy(gameObject, 10f);
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameManager.IncreaseScore();
    }
}
