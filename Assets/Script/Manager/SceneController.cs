using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance;

    private void Awake()
    {
        SceneController.Instance = this;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("LoadScene2");
    }

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene("Stage" + index);
    }
}
