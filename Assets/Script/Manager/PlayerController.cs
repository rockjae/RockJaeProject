using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    private AudioSource audioSource;
    public AudioClip audioClip_Jump;

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

        audioSource = this.GetComponent<AudioSource>();
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
    
    public void JumpBGMPlay()
    {
        audioSource.clip = audioClip_Jump;
        audioSource.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tile")
        {
            TouchUDLR.Instance.setJumpMode(0);
        }
    }
}
