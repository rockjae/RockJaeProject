using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene_test : MonoBehaviour
{
    public int Stage = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            SceneController.Instance.ChangeScene(Stage);
        }
    }
}
