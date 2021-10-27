using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GeneralScript : MonoBehaviour
{
    public static float bottom;
    public static float top;
    public static float left;
    public static float right;

    // so we can manually set outside of code
    public float absoluteLeft = -10; 
    public float absoluteRight = 10;
    public float absoluteTop = 10;
    public float absoluteBottom = -10;

    public static bool gameEnd;
    public static GameObject Player; // pointer to player all code can access
    public GameObject collideTiles;
    public string nextScene;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        gameEnd = false;

        top = absoluteTop;
        bottom = absoluteBottom;
        left = absoluteLeft;
        right = absoluteRight;
    }

    void Update()
    {
        if (gameEnd)
           SceneManager.LoadScene(nextScene);

        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            SceneManager.LoadScene("MainMenu");
        }

        if (Player.GetComponent<Rigidbody2D>() != null)
        {
            if (Player.GetComponent<Rigidbody2D>().velocity.y > 0) // if the player is currently going up 
            {
                collideTiles.GetComponentInChildren<TilemapCollider2D>().enabled = false;
            }
            else
            {
                collideTiles.GetComponentInChildren<TilemapCollider2D>().enabled = true;
            }
        }
    }
    public void GameEnd()
    {
        gameEnd = true;
    }
}
