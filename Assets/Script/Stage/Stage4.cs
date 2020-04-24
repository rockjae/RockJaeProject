using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4 : MonoBehaviour
{
    public static Stage4 Instance;

    private Transform Player;
    public GameObject StageClear;

    private void Awake()
    {
        Stage4.Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Player = PlayerController.Instance.Player.transform;
        Player.transform.position = new Vector3(-2, 4);
    }
}
