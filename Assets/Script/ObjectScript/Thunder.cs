using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tile")
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject == PlayerController.Instance.Player)
        {
            if (!GameOver.Instance.isPlayerDown)
            {
                GameOver.Instance.startGameOver();
            }
        }
    }
}
