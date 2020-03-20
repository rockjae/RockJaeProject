using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        //Player = MainController.Instance.Player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(Player.position.x,Player.position.y, -10);
    }
}
