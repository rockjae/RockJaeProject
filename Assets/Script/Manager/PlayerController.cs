using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    private Animator mPlayer_Animator;
    private Rigidbody2D mPlayer_Rigidbody;
    private float Player_Speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerController.Instance = this;

        mPlayer_Animator = this.GetComponent<Animator>();
        mPlayer_Rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        KeyEvent();
#endif
    }

    public void btnTest(int number)
    {
        Debug.Log(number);
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
                    this.transform.localPosition -= new Vector3(0, Player_Speed * Time.deltaTime);
                    mPlayer_Animator.SetBool("isJump", true);
                    break;
                }
            case 2:
                {
                    this.transform.localPosition -= new Vector3(Player_Speed * Time.deltaTime, 0);
                    mPlayer_Animator.SetBool("isJump", true);

                    this.transform.eulerAngles = new Vector3(0, 180);
                    break;
                }
            case 3:
                {
                    this.transform.localPosition += new Vector3(Player_Speed * Time.deltaTime, 0);
                    mPlayer_Animator.SetBool("isJump", true);

                    this.transform.eulerAngles = new Vector3(0, 0);
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
            this.transform.localPosition -= new Vector3(0, Player_Speed * Time.deltaTime);
            mPlayer_Animator.SetBool("isJump", true);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.localPosition -= new Vector3(Player_Speed * Time.deltaTime, 0);
            mPlayer_Animator.SetBool("isJump", true);

            this.transform.eulerAngles = new Vector3(0, 180);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.localPosition += new Vector3(Player_Speed * Time.deltaTime, 0);
            mPlayer_Animator.SetBool("isJump", true);

            this.transform.eulerAngles = new Vector3(0, 0);
        }

        if (!Input.anyKey)
        {
            mPlayer_Animator.SetBool("isJump", false);
        }
    }
}
