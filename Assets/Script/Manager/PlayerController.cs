using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public GameObject Player;

    private Animator mPlayer_Animator;
    private Rigidbody2D mPlayer_Rigidbody;
    private float Player_Speed = 5f;

    // Start is called before the first frame update
    void Awake()
    {
        PlayerController.Instance = this;

        mPlayer_Animator = Player.GetComponent<Animator>();
        mPlayer_Rigidbody = Player.GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(this.gameObject);
    }
    /*
    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        KeyEvent();
#endif
    }
    */
    public void btnTest(int number)
    {
        Debug.Log(number);
    }

    public void setPlayerAnimation(string mode)
    {
        switch (mode)
        {
            case "idle":
                {
                    Debug.Log("idle");
                    mPlayer_Animator.SetBool("isJump", false);
                    break;
                }
            case "jump":
                {
                    Debug.Log("jump");
                    mPlayer_Animator.SetBool("isJump", true);
                    break;
                }
        }
    }

    public void KeyTouchEvent(int number)
    {
        switch (number)
        {
            case 0:
                {
                    Debug.Log("input down");
                    mPlayer_Rigidbody.AddForce(new Vector2(0, 100f));
                    mPlayer_Animator.SetBool("isJump", true);
                    break;
                }
            case 1:
                {
                    Player.transform.localPosition -= new Vector3(0, Player_Speed * Time.deltaTime);
                    mPlayer_Animator.SetBool("isJump", true);
                    break;
                }
            case 2:
                {
                    Player.transform.localPosition -= new Vector3(Player_Speed * Time.deltaTime, 0);
                    mPlayer_Animator.SetBool("isJump", true);

                    Player.transform.eulerAngles = new Vector3(0, 180);
                    break;
                }
            case 3:
                {
                    Player.transform.localPosition += new Vector3(Player_Speed * Time.deltaTime, 0);
                    mPlayer_Animator.SetBool("isJump", true);

                    Player.transform.eulerAngles = new Vector3(0, 0);
                    break;
                }
        }
    }

    public void TouchkeyUp()
    {
        Debug.Log("input up");
    }

    private void KeyEvent()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //Player.transform.position += new Vector3(0, Player_Speed * Time.deltaTime);
            mPlayer_Rigidbody.AddForce(new Vector2(0, 100f));
            mPlayer_Animator.SetBool("isJump", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.transform.localPosition -= new Vector3(0, Player_Speed * Time.deltaTime);
            mPlayer_Animator.SetBool("isJump", true);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.transform.localPosition -= new Vector3(Player_Speed * Time.deltaTime, 0);
            mPlayer_Animator.SetBool("isJump", true);

            Player.transform.eulerAngles = new Vector3(0, 180);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.transform.localPosition += new Vector3(Player_Speed * Time.deltaTime, 0);
            mPlayer_Animator.SetBool("isJump", true);

            Player.transform.eulerAngles = new Vector3(0, 0);
        }

        if (!Input.anyKey)
        {
            mPlayer_Animator.SetBool("isJump", false);
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("1"+ collision.name);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("2" + collision.name);
    }
    */

    private bool IsCollision = false;
    private int startBtnCount = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "StartBtn")
        {
            IsCollision = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (IsCollision)
        {
            if(collision.gameObject.name == "StartBtn")
            {
                startBtnCount++;
                IsCollision = false;
                if (startBtnCount > 5)
                {
                    SceneController.Instance.ChangeScene(1);
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (IsCollision)
        {
            IsCollision = false;
        }
    }
}
