using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundOBJ : MonoBehaviour
{
    public static BackGroundOBJ Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        BackGroundOBJ.Instance = this;
    }
}
