using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance;
    private AudioSource audioSource;

    public AudioClip BACKGROUND_BGM;
    public AudioClip GAME_OVER_BGM;

    private void Awake()
    {
        BGMManager.Instance = this;
    }

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    public void setStartBGM()
    {
        audioSource.clip = BACKGROUND_BGM;
        audioSource.Play();
    }

    public void setGameOverBGM()
    {
        audioSource.clip = GAME_OVER_BGM;
        audioSource.Play();
    }
}
