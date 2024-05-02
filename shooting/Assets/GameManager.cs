using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject butlletPrefab;
    private Vector3 mousePos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//0:左クリック 1:右クリック
        {
            mousePos = Input.mousePosition;

            mousePos.z = 5f;
            Instantiate(butlletPrefab,
            Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity);
        }
    }
    public void GameRetry()
    {
        SceneManager.LoadScene("Init");
    }
}
