using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;
    public Ball ball;
    private bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {
        gameClearUI.SetActive(false);
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DestoryAllBlocks() && !isGameClear)
        {
            isGameClear = true;
            GameClear();
        }
    }

    // comfirme all blocks are deleted
    private bool DestoryAllBlocks()
    {
        foreach (Block b in blocks)
        {
            if (b != null)
            {
                return false;
            }
        }
        return true;
    }

    public void GameClear()
    {
        // game clear
        Debug.Log("Game Clear!");
        gameClearUI.SetActive(true);
        ball.DeleteBall();
    }

    public void GameOver()
    {
        // game over
        Debug.Log("Game over!");
        gameOverUI.SetActive(true);
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("Initial");
    }


}
