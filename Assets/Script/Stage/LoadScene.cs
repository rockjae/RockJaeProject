using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public static LoadScene Instance;
    private Transform Player;
    
    [HideInInspector]
    public int Stage = 0;

    private void Awake()
    {
        LoadScene.Instance = this;
    }

    private void Start()
    {
        Player = PlayerController.Instance.Player.transform;
        Player.transform.position = new Vector3(-2, 4);
    }

    public void NextScene()
    {
        SceneController.Instance.ChangeScene(Stage);
    }
}
