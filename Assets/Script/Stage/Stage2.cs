using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
    private Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = PlayerController.Instance.Player.transform;
        Player.transform.position = new Vector3(-2, 4);
    }
}
