using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    bool isPlayerDown = false;
    bool isGameOver = false;
       
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isPlayerDown && collision.gameObject == PlayerController.Instance.Player)
        {
            BGMManager.Instance.setGameOverBGM();
            TouchUDLR.Instance.gameObject.SetActive(false);
            Debug.Log("Player GameOver!!");
            GameObject gameObject = Resources.Load("GameOver") as GameObject;
            gameObject = Instantiate(gameObject);

            isPlayerDown = true;
            StartCoroutine(waitRestart());
        }
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
