﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchUDLR_test : MonoBehaviour
{
    public static TouchUDLR_test Instance;

    private Transform Player;
    private Rigidbody2D mPlayer_Rigidbody;

    //private bool IsTouch = false;
    private bool[] IsTouchArray = new bool[5];

    private float speed = 1f;
    private int isJump = 1;

    private void Awake()
    {
        TouchUDLR_test.Instance = this;
    }

    private void Start()
    {
        TestScript item = GetComponent<TestScript>();
        item.OnHover += OnHover_test;
        //Player = PlayerController.Instance.Player.transform;
        //mPlayer_Rigidbody = PlayerController.Instance.mPlayer_Rigidbody;
    }

    void OnHover_test()
    {
        Debug.Log("OnHover_test");
    }
    /*
    // Update is called once per frame
    void Update()
    {
        if (IsTouchArray[2])
        {
            Player.position += new Vector3(0, -speed * Time.deltaTime);
        }

        if (IsTouchArray[3])
        {
            Player.eulerAngles = new Vector3(0, 180);
            //Player.position += new Vector3(-speed * Time.deltaTime, 0);
            mPlayer_Rigidbody.AddForce(new Vector2(-100 * Time.deltaTime, 0));
        }

        if (IsTouchArray[4])
        {
            Player.eulerAngles = new Vector3(0, 0);
            //Player.position += new Vector3(speed * Time.deltaTime, 0);
            mPlayer_Rigidbody.AddForce(new Vector2(100 * Time.deltaTime, 0));
        }
#if UNITY_EDITOR
        edtior_test();
#endif
    }

    private void edtior_test()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (isJump == 0)
            {
                mPlayer_Rigidbody.AddForce(new Vector2(0, 200f));
                isJump = 1;
                PlayerController.Instance.JumpBGMPlay();
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.position += new Vector3(0, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.eulerAngles = new Vector3(0, 180);
            //Player.position += new Vector3(-speed * Time.deltaTime, 0);
            mPlayer_Rigidbody.AddForce(new Vector2(-100 * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.eulerAngles = new Vector3(0, 0);
            //Player.position += new Vector3(speed * Time.deltaTime, 0);
            mPlayer_Rigidbody.AddForce(new Vector2(100 * Time.deltaTime, 0));
        }
    }

    public void setJumpMode(int result)
    {
        isJump = result;
    }

    public void UDLR_Event(int UDLR)
    {
        if (UDLR > 0)
        {
            if (UDLR == 1)
            {
                if (isJump == 0)
                {
                    mPlayer_Rigidbody.AddForce(new Vector2(0, 200f));
                    isJump = 1;
                    PlayerController.Instance.JumpBGMPlay();
                }
            }
            PlayerController.Instance.setPlayerAnimation("jump");
            IsTouchArray[UDLR] = true;
        }
        else
        {
            IsTouchArray[UDLR * (-1)] = false;
        }

        if (!IsTouchArray[1] && !IsTouchArray[2] && !IsTouchArray[3] && !IsTouchArray[4])
        {
            PlayerController.Instance.setPlayerAnimation("idle");
        }
    }*/
}
