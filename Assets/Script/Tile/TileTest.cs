using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter trigger");
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("exit trigger");
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
