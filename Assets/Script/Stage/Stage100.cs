using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage100 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerController.Instance.Player.transform.position = new Vector3(-2, 2);
        PlayerController.Instance.Player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}
