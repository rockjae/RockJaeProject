using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    bool isGameOver = false;
       
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            BGMManager.Instance.setGameOverBGM();
            TouchUDLR.Instance.gameObject.SetActive(false);
            Debug.Log("Player GameOver!!");
            GameObject gameObject = Resources.Load("GameOver") as GameObject;
            gameObject = Instantiate(gameObject);

            StartCoroutine(waitRestart());
        }
    }

    IEnumerator waitRestart()
    {
        yield return new WaitForSeconds(4f);

        isGameOver = true;
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.anyKey)
            {
                isGameOver = false;
                BGMManager.Instance.setStartBGM();
                SceneController.Instance.RestartScene();

                ClearObject.instance.destoryOBJ();  //제일 마지막
            }
        }
    }
}
