using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTest : MonoBehaviour
{

    public int numberOne = 1;   //Obsolete number from older version
    public int numberTwo = 20;  //Obsolete number from older version
    public int numberThree = 0; //Obsolete number from older version

    public Material unpressedMaterial;  //Standard colored material
    public Material pressedMaterial;    //special colored material
    public GameObject Object;
    public bool isOverflown = false;    //obsolete
    // Start is called before the first frame update
    void Start()
    {
        Object.GetComponent<MeshRenderer> ().material = unpressedMaterial;  //set color of object on startup
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Object.GetComponent<MeshRenderer> ().material = pressedMaterial;    //change color to special colored material if button pressed
            
        }  
        else
        {
           Object.GetComponent<MeshRenderer> ().material = unpressedMaterial;   //revert to standard color
        }
    }
}
