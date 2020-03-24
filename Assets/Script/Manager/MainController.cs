using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public static MainController Instance;
    private GameObject Player;

    private int stageNumber = 0;

    private void Awake()
    {
        MainController.Instance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        Player = PlayerController.Instance.Player;
    }
}
