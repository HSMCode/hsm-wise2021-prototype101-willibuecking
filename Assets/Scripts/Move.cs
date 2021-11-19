using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public int speed = 3;
    private bool start = false;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        Debug.Log(pos);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start = true;
        }
        if (start == true)
        {
            //if ()
            //22 right, -10 left
            if(Input.GetKey(KeyCode.Space) && transform.position.x < 22)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            else if(Input.GetKey(KeyCode.Space) && transform.position.x > 22)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else if(!Input.GetKey(KeyCode.Space) && transform.position.z > -10)
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            else if(!Input.GetKey(KeyCode.Space) && transform.position.z < -10)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
        }
    }
}
