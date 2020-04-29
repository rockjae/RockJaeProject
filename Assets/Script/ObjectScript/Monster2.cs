using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            Debug.Log("Player Collision Monster2");
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

            if (time > 3) { break; }
            yield return null;
        }
    }
}
