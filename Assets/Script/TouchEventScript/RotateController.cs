using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.eulerAngles += new Vector3(0,0, (90f/10f)*Time.deltaTime);
    }
}
