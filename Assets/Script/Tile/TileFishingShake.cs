using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFishingShake : MonoBehaviour
{
    private bool isDown = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDown && collision.gameObject == PlayerController.Instance.Player)
        {
            Debug.Log("Player Collision TileFishing");
            StartCoroutine(tileDown());
            isDown = true;
        }
    }

    private IEnumerator tileDown()
    {
        this.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(5f);

        this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        this.GetComponent<BoxCollider2D>().isTrigger = true;
        this.GetComponent<AudioSource>().Play();

        this.GetComponent<Animator>().enabled = false;

        yield return new WaitForSeconds(5f);
        Destroy(transform.parent.gameObject);
    }
}
