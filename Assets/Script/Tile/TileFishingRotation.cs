using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFishingRotation : MonoBehaviour
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
        float time = 0;
        while (true)
        {
            time += Time.deltaTime;
            this.transform.position += new Vector3(0, -5f * Time.deltaTime);
            this.transform.eulerAngles += new Vector3(360f*Time.deltaTime, 360f * Time.deltaTime);

            if (time > 3) { break; }
            yield return null;
        }
    }
}
