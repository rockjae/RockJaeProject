using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestory : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        ClearObject.instance.ClearOBJ += clearAll;
    }

    public void clearAll()
    {
        Debug.Log("destory : " + this.gameObject.name);
        Destroy(this.gameObject);
    }
}
