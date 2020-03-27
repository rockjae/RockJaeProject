using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.Player)
        {
            TouchUDLR.Instance.setJumpMode(0);
        }
    }
}
