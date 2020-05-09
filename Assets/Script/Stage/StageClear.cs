using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            SceneController.Instance.ChangeScene(5);
        }
        else if (collision.gameObject.tag == "tile")
        {
            Destroy(collision.gameObject);
        }
    }
}
