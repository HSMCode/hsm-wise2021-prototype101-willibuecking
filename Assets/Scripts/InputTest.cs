using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public bool spaceNotified = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space was pressed down");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            
            if (spaceNotified == false)
            {
                Debug.Log("Space is being held");
                spaceNotified = true;
            }

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space was released");
            spaceNotified = false;
        }
    }
}
