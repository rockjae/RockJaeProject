using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickeninthcorn : MonoBehaviour
{
    public GameObject FadeOut;

    private GameObject Player;

    private void Start()
    {
        Player = PlayerController.Instance.Player;
    }    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("chicken!");
        if (collision.gameObject == Player)
        {
            FadeOut.SetActive(true);
            StartCoroutine(nextCount());
        }
    }

    private IEnumerator nextCount()
    {
        PlayerController.Instance.Player.transform.position = new Vector3(-2, 2);
        PlayerController.Instance.Player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        yield return new WaitForSeconds(2f);
        FadeOut.SetActive(false);
        TouchUDLR.Instance.StageCount = 1;
    }
}
