using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGyulMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(-2f*Time.deltaTime, 0);
    }
}
