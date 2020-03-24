using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn : MonoBehaviour
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
            Debug.Log("Player Collision");
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
                if (startBtnCount > 2)
                {
                    LoadScene.Instance.NextScene();
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
}
