using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchUDLR : MonoBehaviour
{
    public static TouchUDLR Instance;

    private Transform Player;
    private Rigidbody2D mPlayer_Rigidbody;

    //private bool IsTouch = false;
    private bool[] IsTouchArray = new bool[5];

    private float speed = 2.3f;
    private int isJump = 1;
    private float forceScale = 250f;
    private float forceTimer = 0;
    private float forceTimerEditor = 0;

    private void Awake()
    {
        TouchUDLR.Instance = this;
    }

    private void Start()
    {
        Player = PlayerController.Instance.Player.transform;
        mPlayer_Rigidbody = PlayerController.Instance.mPlayer_Rigidbody;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (IsTouchArray[2])
        {
            Player.position += new Vector3(0, -speed * Time.deltaTime);
        }
        */
        if (IsTouchArray[3])
        {
            Player.eulerAngles = new Vector3(0, 180);
            forceTimer += Time.deltaTime;
            if (forceTimer < 1.5f)
            {
                mPlayer_Rigidbody.AddForce(new Vector2(-(speed*1.2f) * forceTimer, 0));
            }
            else
            {
                //mPlayer_Rigidbody.AddForce(new Vector2(-100 * Time.deltaTime, 0));
                Player.position += new Vector3(-speed * Time.deltaTime, 0);
            }
        }

        if (IsTouchArray[4])
        {
            Player.eulerAngles = new Vector3(0, 0);
            forceTimer += Time.deltaTime;
            if (forceTimer < 1.5f)
            {
                mPlayer_Rigidbody.AddForce(new Vector2((speed * 1.2f) * forceTimer, 0));
            }
            else
            {
                //mPlayer_Rigidbody.AddForce(new Vector2(100 * Time.deltaTime, 0));
                Player.position += new Vector3(speed * Time.deltaTime, 0);
            }
        }

        if(!IsTouchArray[3] && !IsTouchArray[4])
        {
            forceTimer = 0;
        }

#if UNITY_EDITOR
        edtior_test();
#endif
    }
    
    private void edtior_test()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isJump == 0)
            {
                mPlayer_Rigidbody.AddForce(new Vector2(0, forceScale));
                isJump = 1;
                PlayerController.Instance.JumpBGMPlay();
            }
            /*
            else if(isJump == 1)
            {
                mPlayer_Rigidbody.AddForce(new Vector2(0, jumpScale*2));
                isJump = 2;
                PlayerController.Instance.JumpBGMPlay();
            }
            */
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.position += new Vector3(0, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.position += new Vector3(-speed*2 * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.position += new Vector3(speed * 2 * Time.deltaTime, 0);
        }
    }

    public void setJumpMode(int result)
    {
        isJump = result;
    }

    public void UDLR_Event(int UDLR)
    {
        if (UDLR>0)
        {
            if (UDLR == 1)
            {
                if (isJump == 0)
                {
                    mPlayer_Rigidbody.AddForce(new Vector2(0, forceScale));
                    isJump = 1;
                    PlayerController.Instance.JumpBGMPlay();
                }
                /*
                else if (isJump == 1)
                {
                    mPlayer_Rigidbody.AddForce(new Vector2(0, jumpScale*2));
                    isJump = 2;
                    PlayerController.Instance.JumpBGMPlay();
                }
                */
            }
            PlayerController.Instance.setPlayerAnimation("jump");
            IsTouchArray[UDLR] = true;
        }
        else
        {
            IsTouchArray[UDLR*(-1)] = false;
        }

        if (!IsTouchArray[1] && !IsTouchArray[2] && !IsTouchArray[3] && !IsTouchArray[4])
        {
            PlayerController.Instance.setPlayerAnimation("idle");
        }
    }

    public void playAudio()
    {
        this.GetComponent<AudioSource>().Play();
    }
}
