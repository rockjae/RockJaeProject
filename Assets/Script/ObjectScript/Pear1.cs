using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pear1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            SceneController.Instance.ChangeScene(6);
        }
    }
}
