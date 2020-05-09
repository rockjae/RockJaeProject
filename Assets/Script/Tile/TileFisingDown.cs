using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFisingDown : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            if (!GameOver.Instance.isPlayerDown)
            {
                this.GetComponent<AudioSource>().Play();
                this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Stage4.Instance.StageClear.SetActive(true);
            }
        }
    }

    private IEnumerator tileDown()
    {
        yield return null;
    }
}
