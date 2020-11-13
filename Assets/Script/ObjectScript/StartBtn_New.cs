using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn_New : MonoBehaviour
{
    private bool IsCollision = false;
    private int startBtnCount = 0;

    private GameObject Player;

    private void Start()
    {
        Player = PlayerController.Instance.Player;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Debug.Log("OnCollisionEnter2D");
            startBtnCount++;
            if (startBtnCount > 1)
            {
                Debug.Log("startBtnCount > 1");
                StartCoroutine(waitNextScene());
            }
        }
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            IsCollision = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (IsCollision)
        {
            if (collision.gameObject == Player)
            {
                startBtnCount++;
                IsCollision = false;
                if (startBtnCount > 0)
                {
                    //LoadScene.Instance.NextScene();
                    StartCoroutine(waitNextScene());
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (IsCollision)
        {
            IsCollision = false;
        }
    }
    */
    private IEnumerator waitNextScene()
    {
        this.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        SceneController.Instance.ChangeScene(100);
    }
}
