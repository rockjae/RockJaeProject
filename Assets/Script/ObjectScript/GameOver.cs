using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static GameOver Instance;

    public bool isPlayerDown = false;
    public bool isGameOver = false;

    private void Awake()
    {
        GameOver.Instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isPlayerDown && collision.gameObject == PlayerController.Instance.Player)
        {
            startGameOver();
        }
    }

    public void startGameOver()
    {
        BGMManager.Instance.setGameOverBGM();
        TouchUDLR.Instance.gameObject.SetActive(false);
        Debug.Log("Player GameOver!!");
        GameObject gameObject = Resources.Load("GameOver") as GameObject;
        gameObject = Instantiate(gameObject);

        isPlayerDown = true;
        StartCoroutine(waitRestart());
    }

    IEnumerator waitRestart()
    {
        ClearObject.instance.GameOverMsg();
        yield return new WaitForSeconds(4f);
        isGameOver = true;
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.anyKey)
            {
                isPlayerDown = false;
                isGameOver = false;
                BGMManager.Instance.setStartBGM();
                ClearObject.instance.ClearOBJ();
                SceneController.Instance.RestartScene();
            }
        }
    }
}
