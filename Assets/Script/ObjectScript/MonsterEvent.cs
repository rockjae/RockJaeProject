using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEvent : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.gameObject)
        {
            StartCoroutine(disappear());
        }
    }

    private IEnumerator disappear()
    {
        float time = 0;
        while (true)
        {
            this.transform.eulerAngles += new Vector3(0, 0, 360*Time.deltaTime);
            time += Time.deltaTime;
            if(time > 3)
            {
                break;
            }
            yield return null;
        }

        Destroy(this.gameObject);
        yield return null;
    }
}
