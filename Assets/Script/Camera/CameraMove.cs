using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Transform Player;
    private float PlayerJumpH = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Player = PlayerController.Instance.Player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Player.position.x, Player.position.y- PlayerJumpH, -10);
        if (this.transform.position.x < 0)
        {
            this.transform.position = new Vector3(0, Player.position.y - PlayerJumpH, -10);
        }
    }
}
