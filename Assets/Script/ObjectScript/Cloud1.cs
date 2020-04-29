using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud1 : MonoBehaviour
{
    private Transform player;

    private void Start()
    {
        player=PlayerController.Instance.Player.transform;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            Debug.Log("Player Collision TileFishing");
            StartCoroutine(tileDown());
            this.GetComponent<AudioSource>().Play();
        }
    }

    private IEnumerator tileDown()
    {
        float time = 0;
        player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;

        while (true)
        {
            time += Time.deltaTime;
            this.transform.eulerAngles += new Vector3(0, 0, Time.deltaTime * 5000f);
            this.transform.position += new Vector3(0, Time.deltaTime*3f);
            
            player.transform.position += new Vector3(0, Time.deltaTime * 3f);
            player.eulerAngles += new Vector3(0, 0,Time.deltaTime*5000f);

            if (time > 3) {
                player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                break;
            }
            yield return null;
        }
        SceneController.Instance.ChangeScene(3);
    }
}
