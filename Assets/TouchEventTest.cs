using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEventTest : MonoBehaviour
{
    private bool IsTouch = false;
    public Transform testOBJ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TouchEvent(bool IsTouch)
    {
        this.IsTouch = IsTouch;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTouch)
        {
            testOBJ.localPosition += new Vector3(0, 0.1f*Time.deltaTime);
        }
    }
}
