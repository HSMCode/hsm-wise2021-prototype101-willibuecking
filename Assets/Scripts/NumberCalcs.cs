using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCalcs : MonoBehaviour
{   

    public int Integer1 = 3;    //create 3 wholenumber-variables
    public int Integer2 = 7;
    public int Integer3 = 11;
    public float Float1;        //This will be used for calculations later on
    public string Ansage = "Die Summe der ersten drei Variablen dieses Scripts geteilt durch drei ist ";    //This will be some text to make the console-outpur understandable

    // Start is called before the first frame update
    void Start()
    {
        Float1 = (Integer1 + Integer2 + Integer3)/3;    //calculations (sum of three integers divided by 3) 
        Debug.Log(Ansage + Float1);                     //finally print the result
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
