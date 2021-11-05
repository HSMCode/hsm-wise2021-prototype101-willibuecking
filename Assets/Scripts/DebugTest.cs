using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
               int x = 2;
    void Start()
    {
    
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("fuck, this is debugmessage number");
        Debug.Log(x);
        x = x + 1;
    }
}
