using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearObject : MonoBehaviour
{
    public static ClearObject instance;

    public delegate void DestoryOBJ();
    public DestoryOBJ GameOverMsg;
    public DestoryOBJ ClearOBJ;

    private void Awake()
    {
        ClearObject.instance = this;
    }
}
