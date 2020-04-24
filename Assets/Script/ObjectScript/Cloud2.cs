using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            this.GetComponent<AudioSource>().Play();
        }
    }
}
