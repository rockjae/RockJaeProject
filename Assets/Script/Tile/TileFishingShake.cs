﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFishingShake : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            Debug.Log("Player Collision TileFishing");
            StartCoroutine(tileDown());
        }
    }

    private IEnumerator tileDown()
    {
        this.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(5f);

        this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        this.GetComponent<AudioSource>().Play();
    }
}