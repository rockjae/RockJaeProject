using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateUtil : MonoBehaviour
{
    private void Start()
    {
        ClearObject.instance.GameOverMsg += GameOverMsg;
    }

    private void GameOverMsg()
    {
        Debug.Log("test");
    }
}
