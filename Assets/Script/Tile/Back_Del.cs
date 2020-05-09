using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Del : MonoBehaviour
{
    public GameObject Backgournd_p;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Backgournd_p OnCollisionEnter2D");
        if (collision.gameObject.tag == "background")
        {
            GameObject tmp=Instantiate(Backgournd_p);
            tmp.SetActive(true);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "tile")
        {
            Destroy(collision.gameObject);
        }
    }
}
