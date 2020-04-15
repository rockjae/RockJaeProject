﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tile")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject == PlayerController.Instance.Player)
        {
            //GameOver.Instance.startGameOver();
            SceneController.Instance.ChangeScene(4);
        }
    }
}
