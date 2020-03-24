using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchUDLR : MonoBehaviour
{
    private Transform Player;
    private Rigidbody2D mPlayer_Rigidbody;

    private bool IsTouch = false;
    private int UDLR = -1;

    private float speed = 1f;

    private void Start()
    {
        Player = PlayerController.Instance.Player.transform;
        mPlayer_Rigidbody = PlayerController.Instance.mPlayer_Rigidbody;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTouch)
        {
            switch (UDLR)
            {
                /*
                case 0:
                    {
                        //mPlayer_Rigidbody.AddForce(new Vector2(0, 100f));
                        //Player.position += new Vector3(0, speed*Time.deltaTime);
                        break;
                    }
                    */
                case 1:
                    {
                        Player.position += new Vector3(0, -speed * Time.deltaTime);
                        break;
                    }
                case 2:
                    {
                        Player.eulerAngles = new Vector3(0, 180);
                        Player.position += new Vector3(-speed * Time.deltaTime, 0);
                        break;
                    }
                case 3:
                    {
                        Player.eulerAngles = new Vector3(0, 0);
                        Player.position += new Vector3(speed * Time.deltaTime, 0);
                        break;
                    }
                case 4:
                    {
                        Debug.Log("gg");
                        break;
                    }
            }
        }
    }

    public void UDLR_Event(int UDLR)
    {
        switch (UDLR)
        {
            case -1:
                {
                    PlayerController.Instance.setPlayerAnimation("idle");
                    IsTouch = false;
                    break;
                }
            case 0:
                {
                    PlayerController.Instance.setPlayerAnimation("jump");
                    this.UDLR = UDLR;
                    mPlayer_Rigidbody.AddForce(new Vector2(0, 100f));
                    IsTouch = false;
                    break;
                }
            case 1:
                {
                    PlayerController.Instance.setPlayerAnimation("jump");
                    this.UDLR = UDLR;
                    IsTouch = true;
                    break;
                }
            case 2:
                {
                    PlayerController.Instance.setPlayerAnimation("jump");
                    this.UDLR = UDLR;
                    IsTouch = true;
                    break;
                }
            case 3:
                {
                    PlayerController.Instance.setPlayerAnimation("jump");
                    this.UDLR = UDLR;
                    IsTouch = true;
                    break;
                }
            case 4: // click
                {
                    Debug.Log("dd");
                    break;
                }
        }
    }
}
