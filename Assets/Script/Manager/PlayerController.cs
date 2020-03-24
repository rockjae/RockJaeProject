using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    [HideInInspector]
    public GameObject Player;
    [HideInInspector]
    public Animator mPlayer_Animator;
    [HideInInspector]
    public Rigidbody2D mPlayer_Rigidbody;

    // Start is called before the first frame update
    void Awake()
    {
        Player = this.gameObject;
        PlayerController.Instance = this;

        mPlayer_Animator = this.GetComponent<Animator>();
        mPlayer_Rigidbody = this.GetComponent<Rigidbody2D>();
    }

    public void setPlayerAnimation(string mode)
    {
        switch (mode)
        {
            case "idle":
                {
                    mPlayer_Animator.SetBool("isJump", false);
                    break;
                }
            case "jump":
                {
                    mPlayer_Animator.SetBool("isJump", true);
                    break;
                }
        }
    }    
}
