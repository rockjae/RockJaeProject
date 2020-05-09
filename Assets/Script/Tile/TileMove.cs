using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(Time.deltaTime, 0);
    }
}
